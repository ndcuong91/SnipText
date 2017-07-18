namespace Sniptext_DuyCuong
{
    partial class FulScr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FulScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FulScr";
            this.Opacity = 0.5D;
            this.Text = "FulScr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FulScr_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FulScr_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FulScr_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FulScr_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FulScr_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}