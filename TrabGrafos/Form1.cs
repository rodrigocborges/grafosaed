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
            g = graphPanel.CreateGraphics();
            listNodes.Add(new Node(50, 50, Color.Red, g));
            listNodes.Add(new Node(100, 200, Color.Blue, g));
            listNodes.Add(new Node(350, 50, Color.Green, g));
            listNodes.Add(new Node(400, 300, Color.Yellow, g));
            listNodes.Add(new Node(500, 200, Color.Bisque, g));
            listNodes.Add(new Node(600, 300, Color.Crimson, g));
            listNodes.Add(new Node(433, 100, Color.Aquamarine, g));

            //listNodes[0].Connect(listNodes[1]);
            //listNodes[1].Connect(listNodes[2]);
            //listNodes[2].Connect(listNodes[3]);

            for (int i = 0; i < listNodes.Count; i++)
            {
                if (i < listNodes.Count - 1)
                    listNodes[i].Connect(listNodes[i + 1]);
                else
                    listNodes[i].Connect(listNodes[i]);
            } //conecta automaticamente os nodos

            foreach (Node n in listNodes)
                n.DrawNode(); //desenha todos os nodos presentes na lista

            g.Dispose();

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
    }
}
