using System.Windows.Forms;

namespace PopMIDI
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private string AudioFilePath;

        private void OpenFileButton_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "WaveFormオーディオファイル (*.wav) | *.wav; | Mp3オーディオファイル (*.mp3) | *.mp3;" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AudioFilePath = ofd.FileName;
                }
            }
        }
    }
}
