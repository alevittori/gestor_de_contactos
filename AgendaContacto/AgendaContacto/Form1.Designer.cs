namespace AgendaContacto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContacto = new GroupBox();
            btnAgregar = new Button();
            tbMail = new TextBox();
            tbTel = new TextBox();
            tbDni = new TextBox();
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            gbAgenda = new GroupBox();
            btnExportar = new Button();
            lbxAgenda = new ListBox();
            btnImportar = new Button();
            btnGuardar = new Button();
            tbBuscar = new TextBox();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            gbContacto.SuspendLayout();
            gbAgenda.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(btnAgregar);
            gbContacto.Controls.Add(tbMail);
            gbContacto.Controls.Add(tbTel);
            gbContacto.Controls.Add(tbDni);
            gbContacto.Controls.Add(tbNombre);
            gbContacto.Controls.Add(tbApellido);
            gbContacto.Controls.Add(label5);
            gbContacto.Controls.Add(label4);
            gbContacto.Controls.Add(label3);
            gbContacto.Controls.Add(label2);
            gbContacto.Controls.Add(label1);
            gbContacto.Location = new Point(16, 24);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(772, 150);
            gbContacto.TabIndex = 0;
            gbContacto.TabStop = false;
            gbContacto.Text = "Nuevo Contacto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 62);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(135, 105);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(177, 23);
            tbMail.TabIndex = 9;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(460, 70);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(122, 23);
            tbTel.TabIndex = 8;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(460, 34);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(122, 23);
            tbDni.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(135, 70);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(177, 23);
            tbNombre.TabIndex = 6;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(135, 34);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(177, 23);
            tbApellido.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 109);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(151, 501);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 62);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(34, 501);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 62);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(455, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 37);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gbAgenda
            // 
            gbAgenda.Controls.Add(groupBox1);
            gbAgenda.Controls.Add(btnExportar);
            gbAgenda.Controls.Add(lbxAgenda);
            gbAgenda.Controls.Add(btnImportar);
            gbAgenda.Controls.Add(btnGuardar);
            gbAgenda.Location = new Point(16, 199);
            gbAgenda.Name = "gbAgenda";
            gbAgenda.Size = new Size(772, 296);
            gbAgenda.TabIndex = 14;
            gbAgenda.TabStop = false;
            gbAgenda.Text = "Agenda";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(653, 174);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(89, 62);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar Agenda";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // lbxAgenda
            // 
            lbxAgenda.FormattingEnabled = true;
            lbxAgenda.ItemHeight = 15;
            lbxAgenda.Location = new Point(18, 108);
            lbxAgenda.Name = "lbxAgenda";
            lbxAgenda.Size = new Size(564, 169);
            lbxAgenda.TabIndex = 16;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(653, 108);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(89, 62);
            btnImportar.TabIndex = 14;
            btnImportar.Text = "Importar Agenda";
            btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(653, 42);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 62);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar Agenda";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(54, 26);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(240, 23);
            tbBuscar.TabIndex = 15;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 596);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 48);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(18, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 66);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 668);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(gbAgenda);
            Controls.Add(gbContacto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            gbAgenda.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbContacto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbMail;
        private TextBox tbTel;
        private TextBox tbDni;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnBuscar;
        private GroupBox gbAgenda;
        private Button btnExportar;
        private ListBox lbxAgenda;
        private Button btnImportar;
        private Button btnGuardar;
        private TextBox tbBuscar;
        private Button btnSalir;
        private GroupBox groupBox1;
    }
}
