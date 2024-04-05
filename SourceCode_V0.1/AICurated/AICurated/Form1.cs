using Alivever.Com.WinBrowserCrawler;
using System.Speech.Synthesis;
using System.Windows.Forms;


namespace AICurated
{
    public partial class Form1 : Form
    {
        CScript_Article CrrArticle;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Image BgImage;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered= true;
        }

        private void Btn_PlayCrrSecssion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Txt_BgImgUrl.Text))
            {
                //this.PicBox_Background.Load(this.Txt_BgImgUrl.Text);
                this.BgImage = Image.FromFile(this.Txt_BgImgUrl.Text);
                // 处理图片，使绿幕变透明
                // 将处理后的图片显示在PictureBox控件中
                this.PicBox_Background.Image = BgImage;
                
            }

            if (!string.IsNullOrEmpty(this.Txt_ReportImgUrl.Text))
            {
                //this.PicBox_Reporter.Load(this.Txt_ReportImgUrl.Text);
                // 加载原始图片
                Image originalImage = Image.FromFile(this.Txt_ReportImgUrl.Text);
                // 处理图片，使绿幕变透明
                Bitmap transparentImage = MakeGreenScreenTransparent(originalImage);
                // 将处理后的图片显示在PictureBox控件中
                this.PicBox_Reporter.Image = transparentImage;

            }
            timer.Interval = 300; // 设置时间间隔为200毫秒
            timer.Tick += Timer_Tick; // 定时器事件
            timer.Start(); // 启动定时器

            ReadCrrSecssion();

        }//Btn_PlayCrrSecssion_Click(object sender, EventArgs e)

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 如果 pictureBox1 有图像，则进行缩放
            if (PicBox_Background.Image != null)
            {
                // 在UI线程上执行，避免线程冲突
                this.Invoke(new Action(() =>
                {
                    ScalePictureBoxImage(1.03);
                }));
            }
        }

        private void ScalePictureBoxImage(double scale)
        {
            // 获取原始图片
            Image img = PicBox_Background.Image;
            // 计算新的宽度和高度
            int newWidth = (int)(img.Width * scale);
            int newHeight = (int)(img.Height * scale);
            // 创建新的Bitmap作为缩放后的图片
            Bitmap bmp = new Bitmap(img, newWidth, newHeight);
            // 更新PictureBox的Image
            PicBox_Background.Image = bmp;

            // 释放旧图像资源，防止内存泄漏
            if (img != PicBox_Background.InitialImage)
            {
                img.Dispose();
            }
        }
        private async void ReadCrrSecssion()
        {

            // 创建语音合成器实例
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {

                // 设置朗读英文的语音包
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0, new System.Globalization.CultureInfo(this.Cmb_CrrSecssion_Lang.Text));
                synthesizer.Rate = 2; // 增加语速
                string[] sentences = this.Txt_FullText.Text.Split('\n');// (",.!?:。，！？：\n".ToCharArray());

                foreach (string crrTxt in sentences)
                {
                    this.Lab_CC.Text = crrTxt;
                    synthesizer.Speak(crrTxt);

                }

            }

            timer.Stop();

            //this.PicBox_Background.Image = null;
            //this.PicBox_Reporter.Image = null;
            this.Lab_CC.Text = string.Empty;
        }

        private void Btn_ShowAllSpeech_Click(object sender, EventArgs e)
        {
            string txt = string.Empty;
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                // 列出所有安装的语音引擎
                foreach (var voice in synthesizer.GetInstalledVoices())
                {
                    txt += $"Voice: {voice.VoiceInfo.Name}, Culture: {voice.VoiceInfo.Culture} \n";
                }

            }

            MessageBox.Show(txt);

        }

        private void Btn_LoadJsonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\temp"; // 初始目录
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*"; // 文件过滤器
            openFileDialog.FilterIndex = 2; // 默认选择的过滤器索引
            openFileDialog.RestoreDirectory = true; // 打开对话框后恢复原始目录

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string fileName = openFileDialog.FileName;

            // 此处可以添加代码处理文件，例如打开或读取文件内容
            CrrArticle = GJson.LoadFromFile<CScript_Article>(fileName);
            RefreshCrrArticle();

            MessageBox.Show($"Selected file: {fileName}");

        }

        private void RefreshCrrArticle()
        {
            this.Txt_Title.Text = CrrArticle.Title;

            this.Txt_mediaName.Text = CrrArticle.MediaName;
            this.Txt_Keywords.Text = CrrArticle.Keywords;
            this.Txt_Summary.Text = CrrArticle.Summary;

            this.Cmb_Lang_Article.Text = CrrArticle.LangType;


            this.Txt_BgImgUrl.Text = CrrArticle.Sections[0].BgMediaPrompt;
            this.Txt_ReportImgUrl.Text = CrrArticle.Sections[0].RptMediaUrl;
            this.Cmb_CrrSecssion_Lang.Text = CrrArticle.Sections[0].LangType;

            this.Txt_FullText.Text = CrrArticle.Sections[0].FullText;
        }

        private void Btn_AsveAs_Click(object sender, EventArgs e)
        {
            // 创建并配置SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File As";
            saveFileDialog.Filter = "json Files (*.json)|*.json|All Files (*.*)|*.*"; // 设置文件类型过滤器
            saveFileDialog.DefaultExt = "json"; // 默认扩展名
            saveFileDialog.AddExtension = true; // 自动添加扩展名
            saveFileDialog.InitialDirectory = "c:\\temp";

            // 显示对话框并等待用户操作
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string fileName = saveFileDialog.FileName;


            //CrrArticle = CScriptMker_Article.GetEnglishArticle();

            CrrArticle.Title = this.Txt_Title.Text;

            CrrArticle.MediaName = this.Txt_mediaName.Text;
            CrrArticle.Keywords = this.Txt_Keywords.Text;
            CrrArticle.Summary = this.Txt_Summary.Text;

            CrrArticle.LangType = this.Cmb_Lang_Article.Text;

            CrrArticle.Sections[0].BgMediaPrompt = this.Txt_BgImgUrl.Text;
            CrrArticle.Sections[0].RptMediaUrl = this.Txt_ReportImgUrl.Text;
            CrrArticle.Sections[0].LangType = this.Cmb_CrrSecssion_Lang.Text;

            CrrArticle.Sections[0].FullText = this.Txt_FullText.Text;

            GJson.Write2File(fileName, CrrArticle,true);

            MessageBox.Show($"File will be saved as: {fileName}");
        }//Btn_AsveAs_Click(object sender, EventArgs e)

        private void Btn_Demo_Click(object sender, EventArgs e)
        {
            CrrArticle = CScriptMker_Article.GetEnglishArticle();

            RefreshCrrArticle();

        }


        public Bitmap MakeGreenScreenTransparent(Image originalImage)
        {
            // 创建一个和原始图片相同大小的Bitmap对象
            Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

            // 定义绿幕的颜色范围
            // 注意：你可能需要根据实际的绿幕颜色调整这些值
            int greenScreenLowerLimit = 100; // 绿色分量的下限
            int greenScreenUpperLimit = 255; // 绿色分量的上限
            int otherColorUpperLimit = 221;

            // 遍历原始图片的所有像素
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalColor = ((Bitmap)originalImage).GetPixel(x, y);

                    // 检查像素颜色是否在绿幕颜色范围内
                    if ( (originalColor.G >= greenScreenLowerLimit && originalColor.G <= greenScreenUpperLimit)
                        &&
                        (originalColor.R < (originalColor.G*0.9) && originalColor.R < otherColorUpperLimit)
                        &&
                        (originalColor.B < (originalColor.G * 0.9) && originalColor.B < otherColorUpperLimit) )
                    {
                        // 将绿幕颜色的像素替换为透明
                        bitmap.SetPixel(x, y, Color.Transparent);
                    }
                    else
                    {
                        // 保留原始像素颜色
                        bitmap.SetPixel(x, y, originalColor);
                    }
                }
            }

            return bitmap;
        }//MakeGreenScreenTransparent
    }//class Form1 : Form
}