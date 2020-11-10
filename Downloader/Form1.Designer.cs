namespace Downloader
{
    partial class download_form
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
            this.Author_lbl = new System.Windows.Forms.Label();
            this.Resolution_comboBox = new System.Windows.Forms.ComboBox();
            this.Url_textbox = new System.Windows.Forms.TextBox();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.Url_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress_lbl = new System.Windows.Forms.Label();
            this.Download_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Author_lbl
            // 
            this.Author_lbl.AutoSize = true;
            this.Author_lbl.Location = new System.Drawing.Point(28, 124);
            this.Author_lbl.Name = "Author_lbl";
            this.Author_lbl.Size = new System.Drawing.Size(120, 13);
            this.Author_lbl.TabIndex = 0;
            this.Author_lbl.Text = "Downloader by ArahimX";
            // 
            // Resolution_comboBox
            // 
            this.Resolution_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resolution_comboBox.FormattingEnabled = true;
            this.Resolution_comboBox.Items.AddRange(new object[] {
            "360",
            "480",
            "720",
            "1080"});
            this.Resolution_comboBox.Location = new System.Drawing.Point(92, 49);
            this.Resolution_comboBox.Name = "Resolution_comboBox";
            this.Resolution_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Resolution_comboBox.TabIndex = 1;
            // 
            // Url_textbox
            // 
            this.Url_textbox.Location = new System.Drawing.Point(92, 23);
            this.Url_textbox.Name = "Url_textbox";
            this.Url_textbox.Size = new System.Drawing.Size(406, 20);
            this.Url_textbox.TabIndex = 2;
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(31, 85);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(467, 23);
            this.progress_bar.TabIndex = 3;
            // 
            // Url_lbl
            // 
            this.Url_lbl.AutoSize = true;
            this.Url_lbl.Location = new System.Drawing.Point(28, 26);
            this.Url_lbl.Name = "Url_lbl";
            this.Url_lbl.Size = new System.Drawing.Size(49, 13);
            this.Url_lbl.TabIndex = 4;
            this.Url_lbl.Text = "Add Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resolution:";
            // 
            // Progress_lbl
            // 
            this.Progress_lbl.AutoSize = true;
            this.Progress_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Progress_lbl.Location = new System.Drawing.Point(504, 88);
            this.Progress_lbl.Name = "Progress_lbl";
            this.Progress_lbl.Size = new System.Drawing.Size(28, 17);
            this.Progress_lbl.TabIndex = 6;
            this.Progress_lbl.Text = "0%";
            // 
            // Download_button
            // 
            this.Download_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download_button.Location = new System.Drawing.Point(210, 114);
            this.Download_button.Name = "Download_button";
            this.Download_button.Size = new System.Drawing.Size(97, 23);
            this.Download_button.TabIndex = 7;
            this.Download_button.Text = "Download";
            this.Download_button.UseVisualStyleBackColor = true;
            this.Download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // download_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(546, 157);
            this.Controls.Add(this.Download_button);
            this.Controls.Add(this.Progress_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Url_lbl);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.Url_textbox);
            this.Controls.Add(this.Resolution_comboBox);
            this.Controls.Add(this.Author_lbl);
            this.MaximizeBox = false;
            this.Name = "download_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.Load += new System.EventHandler(this.download_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Author_lbl;
        private System.Windows.Forms.ComboBox Resolution_comboBox;
        private System.Windows.Forms.TextBox Url_textbox;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label Url_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Progress_lbl;
        private System.Windows.Forms.Button Download_button;
    }
}

