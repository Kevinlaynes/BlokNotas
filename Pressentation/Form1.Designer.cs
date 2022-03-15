
namespace Pressentation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.toolStripSeparator6,
            this.guardarToolStripMenuItem1,
            this.guardarComoToolStripMenuItem1,
            this.toolStripSeparator7,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo                  ";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem1.Image")));
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.abrirToolStripMenuItem1.Text = "&Abrir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(203, 6);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem1.Image")));
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.guardarToolStripMenuItem1.Text = "&Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // guardarComoToolStripMenuItem1
            // 
            this.guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            this.guardarComoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.guardarComoToolStripMenuItem1.Text = "&Guardar Como";
            this.guardarComoToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(203, 6);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem1,
            this.rehacerToolStripMenuItem1,
            this.toolStripSeparator8,
            this.cortarToolStripMenuItem1,
            this.copiarToolStripMenuItem1,
            this.pegarToolStripMenuItem1,
            this.toolStripSeparator9,
            this.selecionarTodoToolStripMenuItem});
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // deshacerToolStripMenuItem1
            // 
            this.deshacerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deshacerToolStripMenuItem1.Image")));
            this.deshacerToolStripMenuItem1.Name = "deshacerToolStripMenuItem1";
            this.deshacerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.deshacerToolStripMenuItem1.Text = "&Deshacer";
            this.deshacerToolStripMenuItem1.Click += new System.EventHandler(this.deshacerToolStripMenuItem1_Click);
            // 
            // rehacerToolStripMenuItem1
            // 
            this.rehacerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("rehacerToolStripMenuItem1.Image")));
            this.rehacerToolStripMenuItem1.Name = "rehacerToolStripMenuItem1";
            this.rehacerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.rehacerToolStripMenuItem1.Text = "&Rehacer";
            this.rehacerToolStripMenuItem1.Click += new System.EventHandler(this.rehacerToolStripMenuItem1_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(195, 6);
            // 
            // cortarToolStripMenuItem1
            // 
            this.cortarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem1.Image")));
            this.cortarToolStripMenuItem1.Name = "cortarToolStripMenuItem1";
            this.cortarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.cortarToolStripMenuItem1.Text = "&Cortar";
            this.cortarToolStripMenuItem1.Click += new System.EventHandler(this.cortarToolStripMenuItem1_Click);
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem1.Image")));
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.copiarToolStripMenuItem1.Text = "&Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem1.Image")));
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.pegarToolStripMenuItem1.Text = "&Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(195, 6);
            // 
            // selecionarTodoToolStripMenuItem
            // 
            this.selecionarTodoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selecionarTodoToolStripMenuItem.Image")));
            this.selecionarTodoToolStripMenuItem.Name = "selecionarTodoToolStripMenuItem";
            this.selecionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selecionarTodoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.selecionarTodoToolStripMenuItem.Text = "&Selecionar todo";
            this.selecionarTodoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTodoToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fuenteToolStripMenuItem.Image")));
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem1.Image")));
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Block de Notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem selecionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

