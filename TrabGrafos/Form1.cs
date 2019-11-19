using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabGrafos
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private List<Node> listNodes = new List<Node>();

        public Form1()
        {
            InitializeComponent();
            g = graphPanel.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                listNodes.Add(new Node(i, (i+10) * 32, (i + 1)*32, Helpers.RandomColor(), g));
            }

            for (int i = 0; i < listNodes.Count; i++)
            {
                if (i < listNodes.Count - 1)
                    listNodes[i].Connect(listNodes[i + 1], 10);
                else
                    listNodes[i].Connect(listNodes[i], 10);
            } //conecta automaticamente os nodos

            foreach (Node n in listNodes)
                n.DrawNode(); //desenha todos os nodos presentes na lista
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(graphPanel.BackColor);
                graphPanel.Update();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salvarComoImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfDialog = new SaveFileDialog();
                sfDialog.Filter = "Arquivo Jpeg|*.jpg";
                sfDialog.Title = "Salvar grafo em imagem";
                sfDialog.ShowDialog();

                if(sfDialog.FileName != string.Empty)
                {
                    FileStream fs = (FileStream)sfDialog.OpenFile();
                    switch (sfDialog.FilterIndex)
                    {
                        case 1:
                            Bitmap b = new Bitmap(graphPanel.Width, graphPanel.Height, g);
                            b.Save(sfDialog.FileName);
                            break;
                    }
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
     
        List<int> valueCoord = new List<int>();
        int id;

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = graphPanel.CreateGraphics();  //tamanho alterado da tela altera tamanho do graphics
        }

        private void graphPanel_MouseDown(object sender, MouseEventArgs e)
        {
            id = listNodes.Count - 1;

            if (e.Clicks >= 2)
            {
                listNodes.Add(new Node(id, e.X, e.Y, Helpers.RandomColor(), g));
                valueCoord.Add(e.X);
                valueCoord.Add(e.Y);
                listNodes[listNodes.Count - 1].DrawNode();
            }
            else
            {
                //connect nodos
            }
            
            //MessageBox.Show(string.Format("{0},{1}", e.X + 32, e.Y + 32));
        }
    }
}
