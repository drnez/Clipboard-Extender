namespace Extended_Clipboard
{
    public partial class Form1 : Form
    {
        Stream[] ClipAudio = new Stream[5];
        System.Collections.Specialized.StringCollection[] ClipFileDropList = new System.Collections.Specialized.StringCollection[5];
        Image[] ClipImage = new Image[5];
        string[] ClipText = new string[5];

        public void inButtons(int ArrIndex)
        {
            ClipAudio[ArrIndex] = null;
            ClipFileDropList[ArrIndex] = null;
            ClipImage[ArrIndex] = null;
            ClipText[ArrIndex] = null;

            if (Clipboard.ContainsAudio())
            {
                ClipAudio[ArrIndex] = Clipboard.GetAudioStream();
            }
            else if (Clipboard.ContainsFileDropList())
            {
                ClipFileDropList[ArrIndex] = Clipboard.GetFileDropList();
            }
            else if (Clipboard.ContainsImage())
            {
                ClipImage[ArrIndex] = Clipboard.GetImage();
            }
            else if (Clipboard.ContainsText())
            {
                ClipText[ArrIndex] = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("Your clipboard is empty!");
            }
        }

        public void outButtons(int ArrIndex)
        {
            if (ClipAudio[ArrIndex] != null)
            {
                Clipboard.SetAudio(ClipAudio[ArrIndex]);
            }
            else if (ClipFileDropList[ArrIndex] != null)
            {
                Clipboard.SetFileDropList(ClipFileDropList[ArrIndex]);
            }
            else if (ClipImage[ArrIndex] != null)
            {
                Clipboard.SetImage(ClipImage[ArrIndex]);
            }
            else if (ClipText[ArrIndex] != null)
            {
                Clipboard.SetText(ClipText[ArrIndex]);
            }
            else
            {
                MessageBox.Show($"Clipboard {ArrIndex + 1} is empty!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void in1_Click(object sender, EventArgs e)
        {
            inButtons(0);
        }

        private void in2_Click(object sender, EventArgs e)
        {
            inButtons(1);
        }

        private void in3_Click(object sender, EventArgs e)
        {
            inButtons(2);
        }

        private void in4_Click(object sender, EventArgs e)
        {
            inButtons(3);
        }

        private void in5_Click(object sender, EventArgs e)
        {
            inButtons(4);
        }

        private void out1_Click(object sender, EventArgs e)
        {
            outButtons(0);
        }

        private void out2_Click(object sender, EventArgs e)
        {
            outButtons(1);
        }

        private void out3_Click(object sender, EventArgs e)
        {
            outButtons(2);
        }

        private void out4_Click(object sender, EventArgs e)
        {
            outButtons(3);
        }

        private void out5_Click(object sender, EventArgs e)
        {
            outButtons(4);
        }
    }
}