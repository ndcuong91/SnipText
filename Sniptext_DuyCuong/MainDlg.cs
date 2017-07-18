using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;

namespace Sniptext_DuyCuong
{
    public partial class MainDlg : Form
    {
        private Tesseract ocr;
        public Bitmap pic;
        public Graphics screenGraph;
        FulScr FullScr;
        public bool bNew;
        public MainDlg()
        {
            InitializeComponent();
            ocr = new Tesseract("", "eng", Tesseract.OcrEngineMode.OEM_TESSERACT_CUBE_COMBINED);
            FullScr = new FulScr(this);
        }

        private void Option_Click(object sender, EventArgs e)
        {
            #region nghich ngom
            string URL = "http://www.alexa.com";

            // System.Diagnostics.Process.Start("chrome", "http://www.alexa.com");
            //System.Diagnostics.Process.Start(URL);
            string browserName = "iexplore.exe";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                            browserName = "chrome.exe";
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                            browserName = "firefox.exe";
                        else if (progIdValue.ToString().ToLower().Contains("safari"))
                            browserName = "safari.exe";
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                            browserName = "opera.exe";
                    }
                }
            }
            #endregion
            MessageBox.Show("contact titikid@gmail.com");

        }

        private void Snip_Click(object sender, EventArgs e)
        {
            this.Hide();
            FullScr.Show();
            FullScr.mainDlgOpen = false;
        }

        public void NewDialog()
        {
            bNew = true;
            this.ClientSize = new System.Drawing.Size(510, 560);
            this.Controls.Remove(this.Option);
            this.Controls.Remove(this.Snip);

            this.Controls.Add(this.Snip2); 
            this.Controls.Add(this.richText);          
            this.Controls.Add(this.mainPic);    
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.copyImg);
        }

        public void ProcessText(Rectangle rect)
        {
            pic = new Bitmap(rect.Width, rect.Height);
            screenGraph = Graphics.FromImage(pic);
            screenGraph.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            this.mainPic.Size = new System.Drawing.Size(pic.Width, pic.Height);
            mainPic.Image = pic;
        }

        private void Snip2_Click(object sender, EventArgs e)
        {
            this.Hide(); this.Controls.Remove(this.Copy);
            FullScr.mainDlgOpen = false;
            FullScr.ShowDialog();
        }
        private void Scan_Click(object sender, EventArgs e)
        {
            ocr.Recognize(new Image<Bgr, Byte>(pic));
            richText.Text = ocr.GetText();
            if(richText.Text!="") this.Controls.Add(this.Copy);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richText.Text);

            #region test
            //const string userChoice = @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";
            //string progId;
            ////WebBrowser 
            
            ////BrowserApplication browser;
            //using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(userChoice))
            //{
            //    if (userChoiceKey == null)
            //    {
            //        //browser = BrowserApplication.Unknown;
            //        // break;
            //    }
            //    object progIdValue = userChoiceKey.GetValue("Progid");
            //    if (progIdValue == null)
            //    {
            //        // browser = BrowserApplication.Unknown;
            //        // break;
            //    }
            //    progId = progIdValue.ToString();

                
            //   // var inputtextbox = firefox.TextField(Find.ByName("CASE"));
            //   // WebBrowser.
            //    //if (!inputtextbox.Exists)
            //    //{
            //    //    LogError(c, fileNumber, CommonUtils.Messages.ElementNotFound, ClientID);
            //    //    return;
            //    //}
            //    ////You can use TypeText() or value to type what ever you want.

            //    //inputtextbox.Value = "Your Text here.";
            //    //inputtextbox.TypeText("Your Text Here");
            //}
            #endregion
        }

        private void copyImg_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pic);
        }

    }
}
