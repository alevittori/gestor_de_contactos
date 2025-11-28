namespace AgendaContacto
{
    partial class FormEditarContacto
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // tbMail
            // 
            tbMail.Location = new Point(501, 61);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(177, 23);
            tbMail.TabIndex = 19;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(501, 93);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(122, 23);
            tbTel.TabIndex = 18;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(105, 17);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(122, 23);
            tbDni.TabIndex = 17;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(153, 97);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(177, 23);
            tbNombre.TabIndex = 16;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(153, 61);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(177, 23);
            tbApellido.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 101);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 65);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 13;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 21);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 65);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Apellido";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(213, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(144, 48);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(405, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 48);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 224);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbMail);
            Controls.Add(tbTel);
            Controls.Add(tbDni);
            Controls.Add(tbNombre);
            Controls.Add(tbApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormEditarContacto";
            Text = "FormEditarContacto";
            Load += FormEditarContacto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMail;
        private TextBox tbTel;
        private TextBox tbDni;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}