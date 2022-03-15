
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


namespace Pressentation
{
    public partial class Form1 : Form
    {

        private BinaryReader binaryReader;
        public Form1()
        {
            InitializeComponent();
        }



        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {


           
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {


                ofd.Filter = "Archivos  |*.txt|Todos los archivos  |*.*";
                ofd.Title = "Abrir Archivos";

                ofd.ShowDialog();

                StreamReader sr = new StreamReader(ofd.FileName);/*System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName)*/


                this.Text = ofd.FileName;

                richTextBox1.Text = sr.ReadToEnd();

                sr.Close();





            }
            catch (IOException)
            {
                MessageBox.Show("No ha seleccionado ningun archivo para abrir");
            }



        }

        private void guardar()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = " Guardar como ";
            sfd.Filter = "Archivos  |*.txt|Todos los archivos  |*.*";
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            

            try
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(richTextBox1.Text);

                sw.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Debe proporcionar un titulo");

            }

        }
        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();
            var filename = ofd.FileName;

            if (string.IsNullOrWhiteSpace(filename))
            {
                guardar();


            }
            else
            {
                richTextBox1.SaveFile(this.Text, RichTextBoxStreamType.PlainText);


            }

        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deshacerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void rehacerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selecionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectAll();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ft = fontDialog1.ShowDialog();
            if(ft == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                
                richTextBox1.ForeColor = colorDialog1.Color;
            }

        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diseñado por:\nMelany Fernanda Sánchez Castrillo\nKevin Francisco Canales Laynes\nCorreo:\nmelanyfer.san@gmail.com\nkcanales3003@gmail.com","Acerca de",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}