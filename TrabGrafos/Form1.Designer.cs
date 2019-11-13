namespace TrabGrafos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.graphPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoDadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAdjacênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDeAdjacênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fCoord = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(0, 27);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(784, 334);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.gerarToolStripMenuItem,
            this.fCoord});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarComoImagemToolStripMenuItem,
            this.salvarComoDadoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // salvarComoImagemToolStripMenuItem
            // 
            this.salvarComoImagemToolStripMenuItem.Name = "salvarComoImagemToolStripMenuItem";
            this.salvarComoImagemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salvarComoImagemToolStripMenuItem.Text = "Salvar como Imagem";
            this.salvarComoImagemToolStripMenuItem.Click += new System.EventHandler(this.salvarComoImagemToolStripMenuItem_Click);
            // 
            // salvarComoDadoToolStripMenuItem
            // 
            this.salvarComoDadoToolStripMenuItem.Name = "salvarComoDadoToolStripMenuItem";
            this.salvarComoDadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salvarComoDadoToolStripMenuItem.Text = "Salvar como Dado";
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeAdjacênciasToolStripMenuItem,
            this.matrizDeAdjacênciasToolStripMenuItem});
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.gerarToolStripMenuItem.Text = "Gerar";
            // 
            // listaDeAdjacênciasToolStripMenuItem
            // 
            this.listaDeAdjacênciasToolStripMenuItem.Name = "listaDeAdjacênciasToolStripMenuItem";
            this.listaDeAdjacênciasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listaDeAdjacênciasToolStripMenuItem.Text = "Lista de Adjacências";
            // 
            // matrizDeAdjacênciasToolStripMenuItem
            // 
            this.matrizDeAdjacênciasToolStripMenuItem.Name = "matrizDeAdjacênciasToolStripMenuItem";
            this.matrizDeAdjacênciasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.matrizDeAdjacênciasToolStripMenuItem.Text = "Matriz de Adjacências";
            // 
            // fCoord
            // 
            this.fCoord.Name = "fCoord";
            this.fCoord.Size = new System.Drawing.Size(100, 23);
            this.fCoord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fCoord_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Grafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoDadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAdjacênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDeAdjacênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox fCoord;
    }
}

