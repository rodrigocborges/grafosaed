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
            
            int id = 0;
            int posX = 0;
            int posY = 0;
            g = graphPanel.CreateGraphics();
            for (id = 0; id < 5; id++)
            {
                listNodes.Add(new Node(id, posX, posY, Color.Brown, g));
                if ((posX + 32 > graphPanel.Width) || (posY > graphPanel.Height))
                {
                    MessageBox.Show("Chegou");
                    break;
                }
                posX += 30;
                posY += 30;
            }
            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int imageID = 1;
        private void salvarComoImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap b = new Bitmap(graphPanel.Width, graphPanel.Height, g);
                b.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + imageID + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                ++imageID;
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
            id = listNodes.Count-1;
            //MessageBox.Show(Convert.ToString(id));
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                ++id;
                string[] sCoord = fCoord.Text.Split(',');
                valueCoord.Add(Int32.Parse(sCoord[0]));
                valueCoord.Add(Int32.Parse(sCoord[1]));
                listNodes.Add(new Node(id, valueCoord[0], valueCoord[1], Color.Black, g));
                listNodes[listNodes.Count - 1].DrawNode();
                fCoord.Clear();
                valueCoord.Clear();
                //++id;

            }
        }
    }
}
