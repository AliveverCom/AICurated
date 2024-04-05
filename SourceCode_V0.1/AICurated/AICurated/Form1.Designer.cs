namespace AICurated
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicBox_Background = new System.Windows.Forms.PictureBox();
            this.PicBox_Reporter = new System.Windows.Forms.PictureBox();
            this.Lab_JsonFile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_LoadJsonFile = new System.Windows.Forms.Button();
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.Lab_Title = new System.Windows.Forms.Label();
            this.Txt_mediaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Keywords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Summary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_FullText = new System.Windows.Forms.TextBox();
            this.Lab_FullText = new System.Windows.Forms.Label();
            this.Txt_ReportImgUrl = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_CrrSecssion_Lang = new System.Windows.Forms.ComboBox();
            this.Btn_PlayAll = new System.Windows.Forms.Button();
            this.Cmb_CrrSecssion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_SetScript = new System.Windows.Forms.Button();
            this.Btn_PlayCrrSecssion = new System.Windows.Forms.Button();
            this.Btn_ShowAllSpeech = new System.Windows.Forms.Button();
            this.Cmb_Lang_Article = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_BgImgUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lab_CC = new System.Windows.Forms.Label();
            this.Btn_AsveAs = new System.Windows.Forms.Button();
            this.Btn_Demo = new System.Windows.Forms.Button();
            this.panel_Reporter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Reporter)).BeginInit();
            this.panel_Reporter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox_Background
            // 
            this.PicBox_Background.Location = new System.Drawing.Point(12, 12);
            this.PicBox_Background.Name = "PicBox_Background";
            this.PicBox_Background.Size = new System.Drawing.Size(1440, 850);
            this.PicBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Background.TabIndex = 0;
            this.PicBox_Background.TabStop = false;
            // 
            // PicBox_Reporter
            // 
            this.PicBox_Reporter.Location = new System.Drawing.Point(5, 6);
            this.PicBox_Reporter.Name = "PicBox_Reporter";
            this.PicBox_Reporter.Size = new System.Drawing.Size(300, 508);
            this.PicBox_Reporter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Reporter.TabIndex = 1;
            this.PicBox_Reporter.TabStop = false;
            // 
            // Lab_JsonFile
            // 
            this.Lab_JsonFile.AutoSize = true;
            this.Lab_JsonFile.Location = new System.Drawing.Point(1478, 43);
            this.Lab_JsonFile.Name = "Lab_JsonFile";
            this.Lab_JsonFile.Size = new System.Drawing.Size(48, 15);
            this.Lab_JsonFile.TabIndex = 2;
            this.Lab_JsonFile.Text = "JsonFile";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1538, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Btn_LoadJsonFile
            // 
            this.Btn_LoadJsonFile.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_LoadJsonFile.Location = new System.Drawing.Point(1478, 79);
            this.Btn_LoadJsonFile.Name = "Btn_LoadJsonFile";
            this.Btn_LoadJsonFile.Size = new System.Drawing.Size(75, 41);
            this.Btn_LoadJsonFile.TabIndex = 4;
            this.Btn_LoadJsonFile.Text = "Load";
            this.Btn_LoadJsonFile.UseVisualStyleBackColor = false;
            this.Btn_LoadJsonFile.Click += new System.EventHandler(this.Btn_LoadJsonFile_Click);
            // 
            // Txt_Title
            // 
            this.Txt_Title.Location = new System.Drawing.Point(1538, 149);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(334, 23);
            this.Txt_Title.TabIndex = 6;
            // 
            // Lab_Title
            // 
            this.Lab_Title.AutoSize = true;
            this.Lab_Title.Location = new System.Drawing.Point(1478, 152);
            this.Lab_Title.Name = "Lab_Title";
            this.Lab_Title.Size = new System.Drawing.Size(29, 15);
            this.Lab_Title.TabIndex = 5;
            this.Lab_Title.Text = "Title";
            // 
            // Txt_mediaName
            // 
            this.Txt_mediaName.Location = new System.Drawing.Point(1538, 197);
            this.Txt_mediaName.Name = "Txt_mediaName";
            this.Txt_mediaName.Size = new System.Drawing.Size(334, 23);
            this.Txt_mediaName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1478, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Media";
            // 
            // Txt_Keywords
            // 
            this.Txt_Keywords.Location = new System.Drawing.Point(1538, 243);
            this.Txt_Keywords.Name = "Txt_Keywords";
            this.Txt_Keywords.Size = new System.Drawing.Size(334, 23);
            this.Txt_Keywords.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1478, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Keywords";
            // 
            // Txt_Summary
            // 
            this.Txt_Summary.Location = new System.Drawing.Point(1478, 344);
            this.Txt_Summary.Multiline = true;
            this.Txt_Summary.Name = "Txt_Summary";
            this.Txt_Summary.Size = new System.Drawing.Size(394, 38);
            this.Txt_Summary.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1478, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Summary";
            // 
            // Txt_FullText
            // 
            this.Txt_FullText.Location = new System.Drawing.Point(1478, 591);
            this.Txt_FullText.Multiline = true;
            this.Txt_FullText.Name = "Txt_FullText";
            this.Txt_FullText.Size = new System.Drawing.Size(394, 218);
            this.Txt_FullText.TabIndex = 14;
            this.Txt_FullText.Text = resources.GetString("Txt_FullText.Text");
            // 
            // Lab_FullText
            // 
            this.Lab_FullText.AutoSize = true;
            this.Lab_FullText.Location = new System.Drawing.Point(1481, 570);
            this.Lab_FullText.Name = "Lab_FullText";
            this.Lab_FullText.Size = new System.Drawing.Size(50, 15);
            this.Lab_FullText.TabIndex = 13;
            this.Lab_FullText.Text = "Full Text";
            // 
            // Txt_ReportImgUrl
            // 
            this.Txt_ReportImgUrl.Location = new System.Drawing.Point(1538, 462);
            this.Txt_ReportImgUrl.Name = "Txt_ReportImgUrl";
            this.Txt_ReportImgUrl.Size = new System.Drawing.Size(334, 23);
            this.Txt_ReportImgUrl.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1478, 465);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 15);
            this.label22.TabIndex = 15;
            this.label22.Text = "Rpt Img";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1558, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Language";
            // 
            // Cmb_CrrSecssion_Lang
            // 
            this.Cmb_CrrSecssion_Lang.FormattingEnabled = true;
            this.Cmb_CrrSecssion_Lang.Items.AddRange(new object[] {
            "en-US",
            "en-UK",
            "en-IN",
            "zh-CN",
            "de-DE",
            "fr-FR",
            "ja-JP",
            "es-ES",
            "ar-SA"});
            this.Cmb_CrrSecssion_Lang.Location = new System.Drawing.Point(1623, 559);
            this.Cmb_CrrSecssion_Lang.Name = "Cmb_CrrSecssion_Lang";
            this.Cmb_CrrSecssion_Lang.Size = new System.Drawing.Size(81, 23);
            this.Cmb_CrrSecssion_Lang.TabIndex = 20;
            this.Cmb_CrrSecssion_Lang.Text = "en-UK";
            // 
            // Btn_PlayAll
            // 
            this.Btn_PlayAll.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_PlayAll.Location = new System.Drawing.Point(1777, 825);
            this.Btn_PlayAll.Name = "Btn_PlayAll";
            this.Btn_PlayAll.Size = new System.Drawing.Size(95, 37);
            this.Btn_PlayAll.TabIndex = 21;
            this.Btn_PlayAll.Text = "Play All";
            this.Btn_PlayAll.UseVisualStyleBackColor = false;
            // 
            // Cmb_CrrSecssion
            // 
            this.Cmb_CrrSecssion.FormattingEnabled = true;
            this.Cmb_CrrSecssion.Location = new System.Drawing.Point(1795, 562);
            this.Cmb_CrrSecssion.Name = "Cmb_CrrSecssion";
            this.Cmb_CrrSecssion.Size = new System.Drawing.Size(77, 23);
            this.Cmb_CrrSecssion.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1738, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Secssion";
            // 
            // Btn_SetScript
            // 
            this.Btn_SetScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_SetScript.Location = new System.Drawing.Point(1481, 825);
            this.Btn_SetScript.Name = "Btn_SetScript";
            this.Btn_SetScript.Size = new System.Drawing.Size(75, 37);
            this.Btn_SetScript.TabIndex = 24;
            this.Btn_SetScript.Text = "Set Script";
            this.Btn_SetScript.UseVisualStyleBackColor = false;
            // 
            // Btn_PlayCrrSecssion
            // 
            this.Btn_PlayCrrSecssion.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_PlayCrrSecssion.Location = new System.Drawing.Point(1657, 825);
            this.Btn_PlayCrrSecssion.Name = "Btn_PlayCrrSecssion";
            this.Btn_PlayCrrSecssion.Size = new System.Drawing.Size(114, 37);
            this.Btn_PlayCrrSecssion.TabIndex = 25;
            this.Btn_PlayCrrSecssion.Text = "Play CrrSecssion";
            this.Btn_PlayCrrSecssion.UseVisualStyleBackColor = false;
            this.Btn_PlayCrrSecssion.Click += new System.EventHandler(this.Btn_PlayCrrSecssion_Click);
            // 
            // Btn_ShowAllSpeech
            // 
            this.Btn_ShowAllSpeech.Location = new System.Drawing.Point(1673, 83);
            this.Btn_ShowAllSpeech.Name = "Btn_ShowAllSpeech";
            this.Btn_ShowAllSpeech.Size = new System.Drawing.Size(98, 35);
            this.Btn_ShowAllSpeech.TabIndex = 26;
            this.Btn_ShowAllSpeech.Text = "Show Speakers";
            this.Btn_ShowAllSpeech.UseVisualStyleBackColor = true;
            this.Btn_ShowAllSpeech.Click += new System.EventHandler(this.Btn_ShowAllSpeech_Click);
            // 
            // Cmb_Lang_Article
            // 
            this.Cmb_Lang_Article.FormattingEnabled = true;
            this.Cmb_Lang_Article.Items.AddRange(new object[] {
            "en-US",
            "en-UK",
            "en-IN",
            "zh-CN",
            "de-DE",
            "fr-FR",
            "ja-JP",
            "es-ES",
            "ar-SA"});
            this.Cmb_Lang_Article.Location = new System.Drawing.Point(1538, 288);
            this.Cmb_Lang_Article.Name = "Cmb_Lang_Article";
            this.Cmb_Lang_Article.Size = new System.Drawing.Size(81, 23);
            this.Cmb_Lang_Article.TabIndex = 28;
            this.Cmb_Lang_Article.Text = "en-UK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1473, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Language";
            // 
            // Txt_BgImgUrl
            // 
            this.Txt_BgImgUrl.Location = new System.Drawing.Point(1538, 502);
            this.Txt_BgImgUrl.Name = "Txt_BgImgUrl";
            this.Txt_BgImgUrl.Size = new System.Drawing.Size(334, 23);
            this.Txt_BgImgUrl.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1478, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bg Img";
            // 
            // Lab_CC
            // 
            this.Lab_CC.AutoSize = true;
            this.Lab_CC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lab_CC.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lab_CC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lab_CC.Location = new System.Drawing.Point(122, 807);
            this.Lab_CC.Name = "Lab_CC";
            this.Lab_CC.Size = new System.Drawing.Size(71, 26);
            this.Lab_CC.TabIndex = 31;
            this.Lab_CC.Text = "label4";
            // 
            // Btn_AsveAs
            // 
            this.Btn_AsveAs.BackColor = System.Drawing.Color.MistyRose;
            this.Btn_AsveAs.Location = new System.Drawing.Point(1577, 83);
            this.Btn_AsveAs.Name = "Btn_AsveAs";
            this.Btn_AsveAs.Size = new System.Drawing.Size(75, 34);
            this.Btn_AsveAs.TabIndex = 32;
            this.Btn_AsveAs.Text = "Save As";
            this.Btn_AsveAs.UseVisualStyleBackColor = false;
            this.Btn_AsveAs.Click += new System.EventHandler(this.Btn_AsveAs_Click);
            // 
            // Btn_Demo
            // 
            this.Btn_Demo.Location = new System.Drawing.Point(1786, 83);
            this.Btn_Demo.Name = "Btn_Demo";
            this.Btn_Demo.Size = new System.Drawing.Size(75, 35);
            this.Btn_Demo.TabIndex = 33;
            this.Btn_Demo.Text = "Demo";
            this.Btn_Demo.UseVisualStyleBackColor = true;
            this.Btn_Demo.Click += new System.EventHandler(this.Btn_Demo_Click);
            // 
            // panel_Reporter
            // 
            this.panel_Reporter.BackColor = System.Drawing.Color.Transparent;
            this.panel_Reporter.Controls.Add(this.PicBox_Reporter);
            this.panel_Reporter.Location = new System.Drawing.Point(1142, 342);
            this.panel_Reporter.Name = "panel_Reporter";
            this.panel_Reporter.Size = new System.Drawing.Size(310, 520);
            this.panel_Reporter.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 874);
            this.Controls.Add(this.panel_Reporter);
            this.Controls.Add(this.Btn_Demo);
            this.Controls.Add(this.Btn_AsveAs);
            this.Controls.Add(this.Lab_CC);
            this.Controls.Add(this.Txt_BgImgUrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cmb_Lang_Article);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_ShowAllSpeech);
            this.Controls.Add(this.Btn_PlayCrrSecssion);
            this.Controls.Add(this.Btn_SetScript);
            this.Controls.Add(this.Cmb_CrrSecssion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_PlayAll);
            this.Controls.Add(this.Cmb_CrrSecssion_Lang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_ReportImgUrl);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Txt_FullText);
            this.Controls.Add(this.Lab_FullText);
            this.Controls.Add(this.Txt_Summary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Keywords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_mediaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Title);
            this.Controls.Add(this.Lab_Title);
            this.Controls.Add(this.Btn_LoadJsonFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lab_JsonFile);
            this.Controls.Add(this.PicBox_Background);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Reporter)).EndInit();
            this.panel_Reporter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PicBox_Background;
        private PictureBox PicBox_Reporter;
        private Label Lab_JsonFile;
        private TextBox textBox1;
        private Button Btn_LoadJsonFile;
        private TextBox Txt_Title;
        private Label Lab_Title;
        private TextBox Txt_mediaName;
        private Label label1;
        private TextBox Txt_Keywords;
        private Label label2;
        private TextBox Txt_Summary;
        private Label label3;
        private TextBox Txt_FullText;
        private Label Lab_FullText;
        private TextBox Txt_ReportImgUrl;
        private Label label22;
        private Label label5;
        private ComboBox Cmb_CrrSecssion_Lang;
        private Button Btn_PlayAll;
        private ComboBox Cmb_CrrSecssion;
        private Label label6;
        private Button Btn_SetScript;
        private Button Btn_PlayCrrSecssion;
        private Button Btn_ShowAllSpeech;
        private ComboBox Cmb_Lang_Article;
        private Label label7;
        private TextBox Txt_BgImgUrl;
        private Label label8;
        private Label Lab_CC;
        private Button Btn_AsveAs;
        private Button Btn_Demo;
        private Panel panel_Reporter;
    }
}