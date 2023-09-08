namespace Diseñologin1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pbImagEmpresa = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtIngresarUsuario = new System.Windows.Forms.TextBox();
            this.txtIngresarClave = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iLVerOculartar = new System.Windows.Forms.ImageList(this.components);
            this.pBMostrarOcultar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegClave = new System.Windows.Forms.TextBox();
            this.txtRegUsuario = new System.Windows.Forms.TextBox();
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMostrarOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagEmpresa
            // 
            this.pbImagEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbImagEmpresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImagEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbImagEmpresa.Image")));
            this.pbImagEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pbImagEmpresa.Name = "pbImagEmpresa";
            this.pbImagEmpresa.Size = new System.Drawing.Size(258, 344);
            this.pbImagEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagEmpresa.TabIndex = 0;
            this.pbImagEmpresa.TabStop = false;
            this.pbImagEmpresa.Click += new System.EventHandler(this.pbImagEmpresa_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(495, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 26);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtIngresarUsuario
            // 
            this.txtIngresarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIngresarUsuario.Location = new System.Drawing.Point(290, 136);
            this.txtIngresarUsuario.Name = "txtIngresarUsuario";
            this.txtIngresarUsuario.Size = new System.Drawing.Size(214, 20);
            this.txtIngresarUsuario.TabIndex = 2;
            this.txtIngresarUsuario.Text = "Usuario";
            this.txtIngresarUsuario.Click += new System.EventHandler(this.txtIngresarUsuario_Click);
            // 
            // txtIngresarClave
            // 
            this.txtIngresarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarClave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIngresarClave.Location = new System.Drawing.Point(290, 173);
            this.txtIngresarClave.Name = "txtIngresarClave";
            this.txtIngresarClave.Size = new System.Drawing.Size(214, 20);
            this.txtIngresarClave.TabIndex = 4;
            this.txtIngresarClave.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(289, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(214, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegUser
            // 
            this.btnRegUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegUser.ForeColor = System.Drawing.Color.White;
            this.btnRegUser.Location = new System.Drawing.Point(26, 236);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(214, 30);
            this.btnRegUser.TabIndex = 7;
            this.btnRegUser.Text = "registrar";
            this.btnRegUser.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(290, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Olvide el Usuario o la Contraseña";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // iLVerOculartar
            // 
            this.iLVerOculartar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLVerOculartar.ImageStream")));
            this.iLVerOculartar.TransparentColor = System.Drawing.Color.Transparent;
            this.iLVerOculartar.Images.SetKeyName(0, "icons8-invisible-19 (1).png");
            this.iLVerOculartar.Images.SetKeyName(1, "icons8-visible-19.png");
            // 
            // pBMostrarOcultar
            // 
            this.pBMostrarOcultar.Image = ((System.Drawing.Image)(resources.GetObject("pBMostrarOcultar.Image")));
            this.pBMostrarOcultar.Location = new System.Drawing.Point(484, 174);
            this.pBMostrarOcultar.Name = "pBMostrarOcultar";
            this.pBMostrarOcultar.Size = new System.Drawing.Size(19, 18);
            this.pBMostrarOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMostrarOcultar.TabIndex = 9;
            this.pBMostrarOcultar.TabStop = false;
            this.pBMostrarOcultar.Click += new System.EventHandler(this.pBMostrarOcultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registrarse";
            // 
            // txtRegClave
            // 
            this.txtRegClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegClave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRegClave.Location = new System.Drawing.Point(26, 210);
            this.txtRegClave.Name = "txtRegClave";
            this.txtRegClave.Size = new System.Drawing.Size(214, 20);
            this.txtRegClave.TabIndex = 12;
            this.txtRegClave.Text = "Contraseña";
            // 
            // txtRegUsuario
            // 
            this.txtRegUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRegUsuario.Location = new System.Drawing.Point(26, 185);
            this.txtRegUsuario.Name = "txtRegUsuario";
            this.txtRegUsuario.Size = new System.Drawing.Size(214, 20);
            this.txtRegUsuario.TabIndex = 11;
            this.txtRegUsuario.Text = "Usuario";
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRegNombre.Location = new System.Drawing.Point(26, 136);
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(214, 20);
            this.txtRegNombre.TabIndex = 14;
            this.txtRegNombre.Text = "Nombre completo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(26, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 344);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRegUser);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbImagEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegNombre);
            this.Controls.Add(this.txtRegUsuario);
            this.Controls.Add(this.txtRegClave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIngresarClave);
            this.Controls.Add(this.txtIngresarUsuario);
            this.Controls.Add(this.pBMostrarOcultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMostrarOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagEmpresa;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtIngresarUsuario;
        private System.Windows.Forms.TextBox txtIngresarClave;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList iLVerOculartar;
        private System.Windows.Forms.PictureBox pBMostrarOcultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegClave;
        private System.Windows.Forms.TextBox txtRegUsuario;
        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

