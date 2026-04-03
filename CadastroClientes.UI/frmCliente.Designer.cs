namespace CadastroClientes.UI
{
    partial class frmCliente
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            chkAtivo = new Guna.UI2.WinForms.Guna2CheckBox();
            txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(94, 148, 255);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 159);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Cliente";
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
            chkAtivo.Location = new Point(198, 107);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(62, 20);
            chkAtivo.TabIndex = 1;
            chkAtivo.Text = "Ativo";
            chkAtivo.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkAtivo.UncheckedState.BorderRadius = 0;
            chkAtivo.UncheckedState.BorderThickness = 0;
            chkAtivo.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtTelefone
            // 
            txtTelefone.BorderRadius = 5;
            txtTelefone.CustomizableEdges = customizableEdges1;
            txtTelefone.DefaultText = "";
            txtTelefone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefone.Font = new Font("Segoe UI", 9F);
            txtTelefone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefone.Location = new Point(6, 103);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.SelectedText = "";
            txtTelefone.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTelefone.Size = new Size(173, 30);
            txtTelefone.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(6, 65);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(255, 30);
            txtEmail.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 5;
            txtNome.CustomizableEdges = customizableEdges5;
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
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNome.Size = new Size(255, 30);
            txtNome.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(94, 148, 255);
            guna2Panel1.Controls.Add(btnFechar);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.Font = new Font("Century Gothic", 7.8F);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(310, 87);
            guna2Panel1.TabIndex = 6;
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.FromArgb(192, 0, 0);
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(268, 11);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(30, 32);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonFace;
            guna2HtmlLabel1.Location = new Point(53, 31);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(200, 25);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Cadastro de Cliente";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BorderRadius = 5;
            btnCadastrar.CustomizableEdges = customizableEdges10;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.Green;
            btnCadastrar.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(32, 272);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnCadastrar.Size = new Size(99, 37);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 5;
            btnCancelar.CustomizableEdges = customizableEdges12;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Maroon;
            btnCancelar.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(179, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnCancelar.Size = new Size(99, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 340);
            Controls.Add(groupBox1);
            Controls.Add(guna2Panel1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCliente";
            Text = "frmCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chkAtivo;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}