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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            tbTel = new TextBox();
            tbMail = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            gbAgenda = new GroupBox();
            tbBuscar = new TextBox();
            label6 = new Label();
            lbxAgenda = new ListBox();
            btnSalir = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            btnGuardar = new Button();
            gbContacto.SuspendLayout();
            gbAgenda.SuspendLayout();
            SuspendLayout();
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(btnEliminar);
            gbContacto.Controls.Add(btnModificar);
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
            gbContacto.Size = new Size(772, 239);
            gbContacto.TabIndex = 0;
            gbContacto.TabStop = false;
            gbContacto.Text = "Nuevo Contacto";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 109);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Mail";
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
            // tbApellido
            // 
            tbApellido.Location = new Point(135, 34);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(177, 23);
            tbApellido.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(135, 70);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(177, 23);
            tbNombre.TabIndex = 6;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(460, 34);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(122, 23);
            tbDni.TabIndex = 7;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(460, 70);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(122, 23);
            tbTel.TabIndex = 8;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(135, 105);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(177, 23);
            tbMail.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 62);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(653, 96);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 62);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(653, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 62);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(223, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 37);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gbAgenda
            // 
            gbAgenda.Controls.Add(btnExportar);
            gbAgenda.Controls.Add(lbxAgenda);
            gbAgenda.Controls.Add(btnImportar);
            gbAgenda.Controls.Add(btnGuardar);
            gbAgenda.Controls.Add(tbBuscar);
            gbAgenda.Controls.Add(label6);
            gbAgenda.Controls.Add(btnBuscar);
            gbAgenda.Location = new Point(16, 281);
            gbAgenda.Name = "gbAgenda";
            gbAgenda.Size = new Size(772, 261);
            gbAgenda.TabIndex = 14;
            gbAgenda.TabStop = false;
            gbAgenda.Text = "Agenda";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(65, 34);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(122, 23);
            tbBuscar.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 38);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 14;
            label6.Text = "DNI";
            // 
            // lbxAgenda
            // 
            lbxAgenda.FormattingEnabled = true;
            lbxAgenda.ItemHeight = 15;
            lbxAgenda.Location = new Point(18, 74);
            lbxAgenda.Name = "lbxAgenda";
            lbxAgenda.Size = new Size(564, 169);
            lbxAgenda.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 587);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 37);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 668);
            Controls.Add(btnSalir);
            Controls.Add(gbAgenda);
            Controls.Add(gbContacto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            gbAgenda.ResumeLayout(false);
            gbAgenda.PerformLayout();
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
        private Label label6;
        private Button btnSalir;
    }
}
