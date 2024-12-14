using System.Windows.Forms;
using System.IO;

namespace PopMIDI
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
            sPlayButton.Enabled = false;
            sStopButton.Enabled = false;
            audioTimer.Interval = 500;
            audioTimer.Tick += audioTimer_Tick;
        }

        private string title = "PopMIDI";
        private string AudioFilePath;

        private void OpenFileButton_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "Mp3オーディオファイル (*.mp3) | *.mp3; | WaveFormオーディオファイル (*.wav) | *.wav;" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sPlayButton.Enabled = true;
                    AudioFilePath = ofd.FileName;
                    var fileInfo = new FileInfo(AudioFilePath);
                    audioNameLabel.Text = fileInfo.Name;
                }
                else
                {
                    a.Stop();
                    sPlayButton.Enabled = false;
                    sStopButton.Enabled = false;
                    audioNameLabel.Text = "unnamed";
                    timeLabel.Text = "00:00 / 00:00";
                }
            }
        }

        NAudio a = new NAudio();
        Pop p = new Pop();

        private void sPlayButton_Click(object sender, System.EventArgs e)
        {
            this.audioTimer.Start();
            sPlayButton.Enabled = false;
            sStopButton.Enabled = true;
            a.Play(AudioFilePath);
        }

        private void sStopButton_Click(object sender, System.EventArgs e)
        {
            a.Stop();
            sPlayButton.Enabled = true;
            sStopButton.Enabled = false;
            this.audioTimer.Stop();
        }

        private void audioTimer_Tick(object sender, System.EventArgs e)
        {
            var CurrentTime = a.CurrentTime();
            var TotalTime = a.TotalTime();

            if (CurrentTime.HasValue && TotalTime.HasValue)
            {
                timeLabel.Text = $"{CurrentTime.Value:mm\\:ss} / {TotalTime.Value:mm\\:ss}";
                sProgressbar.Maximum = (int)TotalTime.Value.TotalSeconds;
                sProgressbar.Value = (int)CurrentTime.Value.TotalSeconds;
            }
            else
            {
                this.timeLabel.Text = "00:00 / 00:00";
                sProgressbar.Maximum = 0;
                sProgressbar.Value = 0;
            }
        }
    }
}
