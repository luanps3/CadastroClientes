namespace CadastroClientes.UI
{
    partial class frmCadastroUsuario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox1 = new GroupBox();
            chkAtivo = new Guna.UI2.WinForms.Guna2CheckBox();
            txtConfirmarSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            lblMensagem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 5;
            btnCancelar.CustomizableEdges = customizableEdges1;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Maroon;
            btnCancelar.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(174, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelar.Size = new Size(99, 37);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(94, 148, 255);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Font = new Font("Century Gothic", 7.8F);
            guna2Panel1.Location = new Point(0, 1);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(310, 87);
            guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonFace;
            guna2HtmlLabel1.Location = new Point(53, 31);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(201, 25);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Cadastro de Usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(txtConfirmarSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(94, 148, 255);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 213);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Usuário";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkAtivo.CheckedState.BorderRadius = 0;
            chkAtivo.CheckedState.BorderThickness = 0;
            chkAtivo.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(6, 178);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(114, 20);
            chkAtivo.TabIndex = 1;
            chkAtivo.Text = "Usuário Ativo";
            chkAtivo.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkAtivo.UncheckedState.BorderRadius = 0;
            chkAtivo.UncheckedState.BorderThickness = 0;
            chkAtivo.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BorderRadius = 5;
            txtConfirmarSenha.CustomizableEdges = customizableEdges5;
            txtConfirmarSenha.DefaultText = "";
            txtConfirmarSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmarSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmarSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmarSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmarSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmarSenha.Font = new Font("Segoe UI", 9F);
            txtConfirmarSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmarSenha.Location = new Point(6, 141);
            txtConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirme a senha";
            txtConfirmarSenha.SelectedText = "";
            txtConfirmarSenha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmarSenha.Size = new Size(255, 30);
            txtConfirmarSenha.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 5;
            txtSenha.CustomizableEdges = customizableEdges7;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(6, 103);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSenha.Size = new Size(255, 30);
            txtSenha.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.BorderRadius = 5;
            txtLogin.CustomizableEdges = customizableEdges9;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Segoe UI", 9F);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Location = new Point(6, 65);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtLogin.Size = new Size(255, 30);
            txtLogin.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 5;
            txtNome.CustomizableEdges = customizableEdges11;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(6, 27);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtNome.Size = new Size(255, 30);
            txtNome.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BorderRadius = 5;
            btnCadastrar.CustomizableEdges = customizableEdges13;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.Green;
            btnCadastrar.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(27, 336);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCadastrar.Size = new Size(99, 37);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Location = new Point(27, 309);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(61, 22);
            lblMensagem.TabIndex = 3;
            lblMensagem.Text = "Exemplo";
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 396);
            Controls.Add(lblMensagem);
            Controls.Add(groupBox1);
            Controls.Add(guna2Panel1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCadastroUsuario";
            Text = "frmCadastroUsuario";
            Load += frmCadastroUsuario_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmarSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2CheckBox chkAtivo;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMensagem;
    }
}