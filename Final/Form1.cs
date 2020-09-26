using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Threading;
using System.Configuration;
using System.Reflection.Metadata;

namespace MercyProto
{
    public partial class Form1 : Form
    {
        public Grammar grammar;

        public Thread RecThread;
        public Boolean RecognizerState = true;
        public SpeechRecognitionEngine recognizer;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Here we first need to setup the grammar rules:

            GrammarBuilder build = new GrammarBuilder();
            build.AppendDictation();

            grammar = new Grammar(build);

            //In here we initialize the recognizer and setup its events:

            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            //Here will initialize the recognizer thread:

            RecognizerState = true;
            RecThread = new Thread(new ThreadStart(RecThreadFunction));
            RecThread.Start();



        }
        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Recognizer recognizes the speech

            if (!RecognizerState)
                return;

            this.Invoke((MethodInvoker)delegate
            {
                textBox1_TextChanged.Text += (" " + e.Result.Text.ToLower());
                //This will add a space between each word you say
            });
        }
        public void RecThreadFunction()
        {
            //This is on separate threads. Will loop the recognizer when receiving calls

            while (true)
            {
                try
                {
                    recognizer.Recognize();
                }
                catch
                {
                    //Handles errors
                    //Won't hear you, nothing will happen
                }
            }



            public Form1()
        {
            InitializeComponent();
        }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MercyIntro.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MyMercyIntro.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button3_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MyChartIntro.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\Assit.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\UserId.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\LastName.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\Last4.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MonthDay.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\PassReq.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\ContactEmail.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\LastLogin.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\DOB.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\TicketNumber.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\UserIDReq.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\PassReq.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\NoMatch.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\AssistAnything.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MercyEnding.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MyMercyEnding.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\MyChartEnding.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

      

  

        private void button23_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1_TextChanged.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1_TextChanged.Text = String.Empty;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            const string V = @"C:\Users\jjudi\Music\Mercy\PasswordLink.wav";
            const string SoundLocation = V;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundLocation);
            player.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }

       
    }
}
