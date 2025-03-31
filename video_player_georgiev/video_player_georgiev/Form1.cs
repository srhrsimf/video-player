using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MediaInfoDotNet;
namespace video_player_georgiev
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        bool full_win = false;

        public Form1()
        {
            InitializeComponent();
            SetupPanels();
        }
        private void SetupPanels()
        {
            //panel2.Parent = panel1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.uiMode = "none";
            panel2.Visible = false;            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.wmv;*.mpg;*.mpeg;*.mov;*.flv|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = filePath;   
            }
            /*if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загрузка выбранного видео в Windows Media Player
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(full_win == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                menuStrip1.Visible = false;
                axWindowsMediaPlayer1.uiMode = "none";
                this.WindowState = FormWindowState.Maximized;
                full_win = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                menuStrip1.Visible = true;
                axWindowsMediaPlayer1.uiMode = "full";
                this.WindowState = FormWindowState.Normal;
                full_win = false;
            }            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
