using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoRoflai
{
    public partial class Form1 : Form
    {
        FileStream fileStream;
        Byte[] dataBytes;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select where to save text file";
                sfd.Filter = "TXT document|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileStream = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                    dataBytes = Encoding.ASCII.GetBytes(richTextBox1.Text);
                    fileStream.Write(dataBytes, 0, dataBytes.Length);
                    fileStream.Close();
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader;
                string line;
                OpenFileDialog opf = new OpenFileDialog();
                opf.Title = "Select File to Open";
                opf.Filter = "TXT document|*.txt";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = "";
                    streamReader = new StreamReader(opf.FileName);
                    line = streamReader.ReadToEnd();
                    richTextBox1.Text = line;
                    streamReader.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.StackTrace);
            }
        }

        private void AppendButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select where to save text file";
                sfd.Filter = "TXT document|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileStream = new FileStream(sfd.FileName, FileMode.Append);
                    dataBytes = Encoding.ASCII.GetBytes(richTextBox1.Text);
                    fileStream.Write(dataBytes, 0, dataBytes.Length);
                    fileStream.Close();
                }
            }
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            string text;
            string[] words;
            if(richTextBox1.Text.Length>0)
            {
                text = richTextBox1.Text;
                words = text.Split(' ');
                richTextBox1.Text = "";
                foreach(string item in words)
                {
                    richTextBox1.Text += item + Environment.NewLine;
                }
            }
        }

        private void SubstringButton_Click(object sender, EventArgs e)
        {
            string text;
            if (richTextBox1.Text.Length >4 )
            {
                text = richTextBox1.Text;
                richTextBox1.Text = "";
                richTextBox1.Text = Text.Substring(0, 3);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string text;
            if (richTextBox1.Text.Length>0)
            {
                text = richTextBox1.Text;
                string ats = Microsoft.VisualBasic.Interaction.InputBox("Введите текст который хотите найти");
                if (text.Contains(ats))
                {
                    int pos = text.IndexOf(ats);
                    richTextBox1.Focus();
                    richTextBox1.Select(pos,ats.Length);
                }
                else
                {
                    MessageBox.Show("Такой фразы нет");
                }
            }
        }

        private void btnRaides_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                byte[] raides = new byte[fs.Length];
                fs.Read(raides, 0, raides.Length);
                int a = 0;
                int A = 0;
                int b = 0;
                int B = 0;
                foreach (byte item in raides)
                {
                    if ((char)item == 'a') a++;
                    else if ((char)item == 'A') A++;
                    else if ((char)item == 'b') b++;
                    else if ((char)item == 'B') B++;
                }
                var sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(sfd.FileName);
                    writer.WriteLine("a букв: " + a + "\n");
                    writer.WriteLine("A букв: " + A + "\n");
                    writer.WriteLine("b букв: " + b + "\n");
                    writer.WriteLine("B букв: " + B + "\n");
                    writer.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

