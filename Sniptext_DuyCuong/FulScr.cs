using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sniptext_DuyCuong
{
    public partial class FulScr : Form
    {
        Point startPos, currentPos;    // current mouse position
        bool drawing;
        MainDlg mainDlg;
        public bool mainDlgOpen;
 
        public FulScr(MainDlg form1)
        {
            InitializeComponent();
            mainDlgOpen = false;
            mainDlg = form1;

        }

        private void FulScr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Hide();
                this.mainDlgOpen = false;
                mainDlg.Show();
            }
        }

        public void FulScr_MouseDown(object sender, MouseEventArgs e)
        {
            if (mainDlgOpen) return;
            currentPos = startPos = e.Location;
            drawing = true;
        }

        public void FulScr_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainDlgOpen) return;
            currentPos = e.Location;
            if (drawing) this.Invalidate();
        }

        public void FulScr_MouseUp(object sender, MouseEventArgs e)
        {
            if (mainDlgOpen) return;
            this.Hide();
            if (mainDlg.bNew == false) mainDlg.NewDialog();

            drawing = false;
            mainDlgOpen = true;
            mainDlg.ProcessText(GetRectangle());
            mainDlg.Show();

        }

        private void FulScr_Paint(object sender, PaintEventArgs e)
        {
            if (drawing) e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(Math.Min(startPos.X, currentPos.X), Math.Min(startPos.Y, currentPos.Y),
                                  Math.Abs(startPos.X - currentPos.X), Math.Abs(startPos.Y - currentPos.Y));
        }

   
    }
}
