using NAudio;
using NAudio.Dmo;
using NAudio.Wave;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace music_player
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer pl = new WMPLib.WindowsMediaPlayer();

        AudioFileReader audio_file;

        string[] lst;
        int idx = 0;
        public Form1()
        {
            InitializeComponent();


        }


        private void vis()
        {
            pass.Enabled = true;
            loop.Enabled = true;
            prev.Enabled = true;
            next.Enabled = true;
            prev_15.Enabled = true;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var di = new OpenFileDialog();

            var res = di.ShowDialog();
            if (res == DialogResult.OK)
            {


                pl.URL = di.FileName;
                pl.controls.play();

                pictureBox1.Visible = true;
                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");
                vis();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (pl.settings.volume - 10 >= 0)
                pl.settings.volume -= 10;
            else
            {
                button7.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-no-audio-100 (1).png");
                pl.settings.volume = 0;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pl.settings.volume <= 100)
            {
                button7.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-low-volume-100.png");
            }
            if (pl.settings.volume + 10 <= 100)
                pl.settings.volume += 10;
        }

        private void pass_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pl.controls.stop();

                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-play-100.png");

                pictureBox1.Visible = false;
            }
            else
            {
                pl.controls.play();
                pictureBox1.Visible = true;
                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");

            }

        }

        private void folder_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog();
            di.Multiselect = true;

            var res = di.ShowDialog();
            if (res == DialogResult.OK)
            {
                lst = di.FileNames;

                pl.URL = lst[0];
                pl.controls.play();



                pictureBox1.Visible = true;
                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");
                vis();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (lst != null)
            {
                idx = (idx + 1 >= lst.Length ? 0 : idx + 1);
                pl.controls.stop();

                pl.URL = lst[idx];
                pl.controls.play();


                pictureBox1.Visible = true;
                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");

            }
            else
            {

                string message = "You should select a folder";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    pl.controls.stop();

                    var di = new OpenFileDialog();
                    di.Multiselect = true;

                    var res = di.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        lst = di.FileNames;

                        pl.URL = lst[idx];
                        pl.controls.play();

                        pictureBox1.Visible = true;
                        pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");
                        vis();
                    }
                }
                else
                {
                    this.Close();
                }


            }


        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (lst != null)
            {
                idx = (idx - 1 < 0 ? lst.Length - 1 : idx - 1);
                pl.controls.stop();
                pl.URL = lst[idx];
                pl.controls.play();

                pictureBox1.Visible = true;
                pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");

            }
            else
            {
                string message = "You should select a folder ";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    pl.controls.stop();
                    var di = new OpenFileDialog();
                    di.Multiselect = true;

                    var res = di.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        lst = di.FileNames;
                        pl.URL = lst[idx];
                        pl.controls.play();

                        pictureBox1.Visible = true;
                        pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");
                        vis();
                    }
                }
                else
                {
                    this.Close();
                }


            }

        }

        private void loop_Click(object sender, EventArgs e)
        {
            pl.controls.stop();
            pl.controls.play();

            pictureBox1.Visible = true;
            pass.Image = Image.FromFile("D:\\Aprojects\\backend_projects\\first\\music player\\icon\\icons8-pause-100.png");


        }

        private void prev_15_Click(object sender, EventArgs e)
        {
            try
            {
                pl.controls.currentPosition = pl.controls.currentPosition - 15;


            }
            catch (Exception ex)
            {

                pl.controls.currentPosition = 0;

            }





        }
    }
}