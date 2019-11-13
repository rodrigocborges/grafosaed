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

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, x1, y1, x2, y2);
            pen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < listNodes.Count; i++)
            {
                if (i < listNodes.Count - 1)
                    listNodes[i].Connect(listNodes[i + 1]);
                else
                    listNodes[i].Connect(listNodes[i]);
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

        private void fCoord_KeyDown(object sender, KeyEventArgs e)
        {
            id = listNodes.Count - 1;
            //MessageBox.Show(Convert.ToString(id));
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                ++id;
                string[] sCoord = fCoord.Text.Split(',');
                valueCoord.Add(Int32.Parse(sCoord[0]));
                valueCoord.Add(Int32.Parse(sCoord[1]));
                listNodes.Add(new Node(id, valueCoord[0], valueCoord[1], Color.Black, g));
                listNodes[listNodes.Count - 1].DrawNode();
                listNodes[id].Connect(listNodes[listNodes.Count - 1]);
                fCoord.Clear();
                valueCoord.Clear();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = graphPanel.CreateGraphics();
        }
    }
}
