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
        public int x;
        public int y;
        public List<Node> parent;
        public Color color;
        private Graphics g;

        private int size = 32;

        public Node(int x, int y, Color c, Graphics g)
        {
            Random r = new Random();
            this.x = x;
            this.y = y;
            this.color = c;
            this.g = g;
            this.parent = null;
        }

        public void DrawNode()
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, size, size);
            brush.Dispose();
        }

        private double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        } //distância entre 2 pontos

        public void Connect(Node n)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, x + (size/2), y, n.x + (size / 2), n.y);
        }
    }
}
