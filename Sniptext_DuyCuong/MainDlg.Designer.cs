namespace Sniptext_DuyCuong
{
    partial class MainDlg
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
            this.Option = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.Scan = new System.Windows.Forms.Button();
            this.Snip = new System.Windows.Forms.Button();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.Snip2 = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.copyImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Option.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option.Location = new System.Drawing.Point(130, 14);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(81, 50);
            this.Option.TabIndex = 2;
            this.Option.Text = "Help";
            this.Option.UseVisualStyleBackColor = true;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(5, 5);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(500, 100);
            this.richText.TabIndex = 3;
            this.richText.Text = "";
            // 
            // Scan
            // 
            this.Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.Location = new System.Drawing.Point(90, 110);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(70, 40);
            this.Scan.TabIndex = 3;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Snip
            // 
            this.Snip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Snip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Snip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snip.Location = new System.Drawing.Point(21, 15);
            this.Snip.Name = "Snip";
            this.Snip.Size = new System.Drawing.Size(81, 50);
            this.Snip.TabIndex = 1;
            this.Snip.Text = "New";
            this.Snip.UseVisualStyleBackColor = true;
            this.Snip.Click += new System.EventHandler(this.Snip_Click);
            // 
            // mainPic
            // 
            this.mainPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPic.Location = new System.Drawing.Point(5, 155);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(100, 50);
            this.mainPic.TabIndex = 2;
            this.mainPic.TabStop = false;
            // 
            // Snip2
            // 
            this.Snip2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Snip2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Snip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snip2.Location = new System.Drawing.Point(5, 110);
            this.Snip2.Name = "Snip2";
            this.Snip2.Size = new System.Drawing.Size(70, 40);
            this.Snip2.TabIndex = 3;
            this.Snip2.Text = "New";
            this.Snip2.UseVisualStyleBackColor = true;
            this.Snip2.Click += new System.EventHandler(this.Snip2_Click);
            // 
            // Copy
            // 
            this.Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.Location = new System.Drawing.Point(300, 110);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(110, 40);
            this.Copy.TabIndex = 3;
            this.Copy.Text = "CopyText";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // copyImg
            // 
            this.copyImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.copyImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyImg.Location = new System.Drawing.Point(175, 110);
            this.copyImg.Name = "copyImg";
            this.copyImg.Size = new System.Drawing.Size(115, 40);
            this.copyImg.TabIndex = 3;
            this.copyImg.Text = "CopyImage";
            this.copyImg.UseVisualStyleBackColor = true;
            this.copyImg.Click += new System.EventHandler(this.copyImg_Click);
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(241, 86);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.Snip);
            this.Name = "MainDlg";
            this.Text = "SnipText";
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Snip;
        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Button Option;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Snip2;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button copyImg;
    }
}

