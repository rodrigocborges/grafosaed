using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrabGrafos
{
    public class Node
    {
        /* Classe para referenciar posições de cada nodo e suas respectivas ligações com outros
           nodos caso houver 
         */
        public int id = 0;
        public int x;
        public int y;
        public List<Node> parent;
        public Color color;

        private Graphics g;
        private int size = 32;

        public Node(int id, int x, int y, Color c, Graphics g)
        {
            this.id = id;
            Random r = new Random();
            this.x = x;
            this.y = y;
            this.color = c;
            this.g = g;
            this.parent = new List<Node>();
        }

        public void DrawNode()
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, size, size);
            g.DrawString(id.ToString(), new Font("Arial", 16), new SolidBrush(Color.White), this.x + (size / 4), this.y + (size / 4));
            brush.Dispose();
        }

        private double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        } //distância entre 2 pontos

        public void Connect(Node n)
        {
            this.parent.Add(n); //adiciona conexão na lista de conexões
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, x + (size/2), y + (size/2), n.x + (size/2), n.y + (size/2));
        }
    }
}
