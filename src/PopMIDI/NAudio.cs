using System.Windows.Forms;
using NAudio.Wave;
using System;

namespace PopMIDI
{
    internal class NAudio
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public void Play(string AudioFilePath)
        {
            try
            {
                audioFile = new AudioFileReader(AudioFilePath);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NAudio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        public TimeSpan? CurrentTime()
        {
            return audioFile?.CurrentTime;
        }

        public TimeSpan? TotalTime()
        {
            return audioFile?.TotalTime;
        }
    }
}
