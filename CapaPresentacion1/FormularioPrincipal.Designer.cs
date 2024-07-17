namespace CapaPresentacion1
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menucursos = new FontAwesome.Sharp.IconMenuItem();
            this.menuinscripcion = new FontAwesome.Sharp.IconMenuItem();
            this.sudmenuinscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.sudmenuestudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.sudmenupagos = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menudocentes = new FontAwesome.Sharp.IconMenuItem();
            this.inscripcionDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuciclos = new FontAwesome.Sharp.IconMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.contenedor);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 530);
            this.panel1.TabIndex = 0;
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(218, 3);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(674, 524);
            this.contenedor.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucursos,
            this.menuinscripcion,
            this.menudocentes,
            this.menuciclos});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(215, 530);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menucursos
            // 
            this.menucursos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.menucursos.IconColor = System.Drawing.Color.Black;
            this.menucursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucursos.Name = "menucursos";
            this.menucursos.Size = new System.Drawing.Size(210, 52);
            this.menucursos.Text = "Agregar Libros";
            this.menucursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuinscripcion
            // 
            this.menuinscripcion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudmenuinscripcion,
            this.sudmenuestudiantes,
            this.sudmenupagos,
            this.inscripcionesToolStripMenuItem});
            this.menuinscripcion.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.menuinscripcion.IconColor = System.Drawing.Color.Black;
            this.menuinscripcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuinscripcion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinscripcion.Name = "menuinscripcion";
            this.menuinscripcion.Size = new System.Drawing.Size(210, 52);
            this.menuinscripcion.Text = "Gestionar Proveedores";
            // 
            // sudmenuinscripcion
            // 
            this.sudmenuinscripcion.Name = "sudmenuinscripcion";
            this.sudmenuinscripcion.Size = new System.Drawing.Size(209, 22);
            this.sudmenuinscripcion.Text = "Plataforma de Inscripcion";
            // 
            // sudmenuestudiantes
            // 
            this.sudmenuestudiantes.Name = "sudmenuestudiantes";
            this.sudmenuestudiantes.Size = new System.Drawing.Size(209, 22);
            this.sudmenuestudiantes.Text = "Estudiantes";
            // 
            // sudmenupagos
            // 
            this.sudmenupagos.Name = "sudmenupagos";
            this.sudmenupagos.Size = new System.Drawing.Size(209, 22);
            this.sudmenupagos.Text = "Pagos";
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            // 
            // menudocentes
            // 
            this.menudocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionDocentesToolStripMenuItem,
            this.datosDocentesToolStripMenuItem,
            this.relacionesToolStripMenuItem});
            this.menudocentes.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.menudocentes.IconColor = System.Drawing.Color.Black;
            this.menudocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menudocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menudocentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menudocentes.Name = "menudocentes";
            this.menudocentes.Size = new System.Drawing.Size(210, 52);
            this.menudocentes.Text = "Gestionar Libros";
            // 
            // inscripcionDocentesToolStripMenuItem
            // 
            this.inscripcionDocentesToolStripMenuItem.Name = "inscripcionDocentesToolStripMenuItem";
            this.inscripcionDocentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inscripcionDocentesToolStripMenuItem.Text = "Registrar";
            // 
            // datosDocentesToolStripMenuItem
            // 
            this.datosDocentesToolStripMenuItem.Name = "datosDocentesToolStripMenuItem";
            this.datosDocentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosDocentesToolStripMenuItem.Text = "Datos";
            // 
            // relacionesToolStripMenuItem
            // 
            this.relacionesToolStripMenuItem.Name = "relacionesToolStripMenuItem";
            this.relacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relacionesToolStripMenuItem.Text = "Relaciones";
            // 
            // menuciclos
            // 
            this.menuciclos.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.menuciclos.IconColor = System.Drawing.Color.Black;
            this.menuciclos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuciclos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuciclos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuciclos.Name = "menuciclos";
            this.menuciclos.Size = new System.Drawing.Size(210, 52);
            this.menuciclos.Text = "Gestionar Categorias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Formulario Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 526);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuinscripcion;
        private System.Windows.Forms.ToolStripMenuItem sudmenuinscripcion;
        private System.Windows.Forms.ToolStripMenuItem sudmenuestudiantes;
        private System.Windows.Forms.ToolStripMenuItem sudmenupagos;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menudocentes;
        private System.Windows.Forms.ToolStripMenuItem inscripcionDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacionesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuciclos;
        private FontAwesome.Sharp.IconMenuItem menucursos;
        private System.Windows.Forms.Panel contenedor;
    }
}