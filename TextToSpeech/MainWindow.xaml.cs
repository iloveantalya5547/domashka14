using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextToSpeech
{
    public partial class MainWindow : Window
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
        public void Error()
        {
            MessageBox.Show("Error occured", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch(cbSelect.SelectedIndex){
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 2:
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                }
                voice.SpeakAsync(TextBox.Text);
            }

            catch
            {
                Error();
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                voice.Pause();
            }

            catch
            {
                Error();
            }
        }

        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                voice.Resume();
            }

            catch
            {
                Error();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //wip :(
            }

            catch
            {
                Error();
            }
        }
    }
}
