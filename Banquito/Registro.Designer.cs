namespace Banquito
{
    partial class Registro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtRepetirContrasena = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            btnRegistro = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 126);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 190);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 257);
            label3.Name = "label3";
            label3.Size = new Size(221, 32);
            label3.TabIndex = 2;
            label3.Text = "Repetir Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 328);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 393);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 4;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 464);
            label6.Name = "label6";
            label6.Size = new Size(195, 32);
            label6.TabIndex = 5;
            label6.Text = "Apellido Paterno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 523);
            label7.Name = "label7";
            label7.Size = new Size(205, 32);
            label7.TabIndex = 6;
            label7.Text = "Apellido Materno:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(342, 126);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(361, 39);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(342, 190);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(361, 39);
            txtContrasena.TabIndex = 1;
            // 
            // txtRepetirContrasena
            // 
            txtRepetirContrasena.Location = new Point(342, 254);
            txtRepetirContrasena.Name = "txtRepetirContrasena";
            txtRepetirContrasena.Size = new Size(361, 39);
            txtRepetirContrasena.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(342, 325);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 39);
            txtCorreo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(342, 393);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 39);
            txtNombre.TabIndex = 4;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(342, 464);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(361, 39);
            txtApellidoPaterno.TabIndex = 5;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(342, 533);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(361, 39);
            txtApellidoMaterno.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(63, 616);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(315, 46);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Fainalizar Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 616);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(283, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistro);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreo);
            Controls.Add(txtRepetirContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtRepetirContrasena;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private Button btnRegistro;
        private Button btnCancelar;
    }
}