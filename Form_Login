using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SendMe
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public void Form_Login_Load(object sender, EventArgs e)
        {
            // Criação de objetos.
            #region

                // Button - Sair.
                #region
                    Button Button_Sair = new Button();
                    Button_Sair.BackColor = Color.FromArgb(46, 48, 61);
                    Button_Sair.FlatAppearance.BorderSize = 0;
                    Button_Sair.FlatAppearance.MouseDownBackColor = Color.Red;
                    Button_Sair.FlatAppearance.MouseOverBackColor = Color.Red;
                    Button_Sair.FlatStyle = FlatStyle.Flat;
                    Button_Sair.Font = new Font("Segoe UI Symbol", 11, FontStyle.Regular);
                    Button_Sair.ForeColor = Color.White;
                    Button_Sair.Location = new Point(410, 5);
                    Button_Sair.Name = "Button_Sair";
                    Button_Sair.Size = new Size(70, 30);
                    Button_Sair.Text = "X";
                    Button_Sair.Click += new EventHandler(Button_Sair_Click);
                    this.Controls.Add(Button_Sair);
                    ToolTip ToolTip_Sair = new ToolTip();
                    ToolTip_Sair.SetToolTip(Button_Sair, "Sair");
                #endregion

                // Button - Minimizar.
                #region   
                    Button Button_Minimizar = new Button();
                    Button_Minimizar.BackColor = Color.FromArgb(46, 48, 61);
                    Button_Minimizar.FlatAppearance.BorderSize = 0;
                    Button_Minimizar.FlatStyle = FlatStyle.Flat;
                    Button_Minimizar.Font = new Font("Segoe UI Symbol", 11, FontStyle.Regular);
                    Button_Minimizar.ForeColor = Color.White;
                    Button_Minimizar.Location = new Point(335, 5);
                    Button_Minimizar.Name = "Button_Minimizar";
                    Button_Minimizar.Size = new Size(70, 30);
                    Button_Minimizar.Text = "__";
                    Button_Minimizar.Click += new EventHandler(Button_Minimizar_Cick);
                    this.Controls.Add(Button_Minimizar);
                    ToolTip ToolTip_Minimizar = new ToolTip();
                    ToolTip_Minimizar.SetToolTip(Button_Minimizar, "Minimizar");
                #endregion

                // Label - Título.
                #region
                    Label Label_Título = new Label();
                    Label_Título.BorderStyle = BorderStyle.None;
                    Label_Título.FlatStyle = FlatStyle.Flat;
                    Label_Título.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    Label_Título.ForeColor = Color.FromArgb(0, 182, 152);
                    Label_Título.Left = (this.ClientSize.Width - Label_Título.Width) / 2;
                    Label_Título.Location = new Point(215, 10);
                    Label_Título.Name = "Label_Título";
                    Label_Título.Size = new Size(63, 17);
                    Label_Título.Text = "SendMe";
                    this.Controls.Add(Label_Título);
                #endregion

                // PictureBox - Logotipo.
                #region
                    PictureBox PictureBox_Logotipo = new PictureBox();
                    PictureBox_Logotipo.BackColor = Color.FromArgb(46, 48, 61);
                    PictureBox_Logotipo.BorderStyle = BorderStyle.None;
                    PictureBox_Logotipo.Location = new Point(40 , 63);
                    PictureBox_Logotipo.Size = new Size(400, 120);
                    PictureBox_Logotipo.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBox_Logotipo.WaitOnLoad = true;
                    this.Controls.Add(PictureBox_Logotipo);
                #endregion

                // TextBox - Email.
                #region
                    Layout.MonoFlat_TextBox TextBox_Email = new Layout.MonoFlat_TextBox();
                    TextBox_Email.Font = new Font("Tahoma", 11, FontStyle.Regular);
                    TextBox_Email.Location = new Point(92, 220);
                    TextBox_Email.Name = "TextBox_Email";
                    TextBox_Email.Size = new Size(300, 40);
                    TextBox_Email.Text = "Email";
                    this.Controls.Add(TextBox_Email);
                #endregion

                // TextBox - Senha.
                #region
                    Layout.MonoFlat_TextBox TextBox_Senha = new Layout.MonoFlat_TextBox();
                    TextBox_Senha.Font = new Font("Tahoma", 11, FontStyle.Regular);
                    TextBox_Senha.Location = new Point(92, 267);
                    TextBox_Senha.Size = new Size(300, 40);
                    TextBox_Senha.Text = "Senha";
                    TextBox_Senha.UseSystemPasswordChar = true;
                    TextBox_Senha.Click += new EventHandler(TextBox_Senha_Click);
                    this.Controls.Add(TextBox_Senha);
                #endregion

                // Button - Entrar.
                #region
                    Button Button_Entrar = new Button();
                    Button_Entrar.BackColor = Color.FromArgb(0, 182, 152);
                    Button_Entrar.FlatAppearance.BorderSize = 0;
                    Button_Entrar.FlatStyle = FlatStyle.Flat;
                    Button_Entrar.Font = new Font("Tahoma", 12, FontStyle.Regular);
                    Button_Entrar.ForeColor = Color.White;
                    Button_Entrar.Location = new Point(92, 314);
                    Button_Entrar.Name = "Button_Entrar";
                    Button_Entrar.Size = new Size(300, 45);
                    Button_Entrar.Text = "Entrar";
                    this.Controls.Add(Button_Entrar);
            #endregion

                // CheckBox - Login Automático.
                #region
                    Layout.MonoFlat_CheckBox CheckBox_LoginAutomático = new Layout.MonoFlat_CheckBox();
                    CheckBox_LoginAutomático.Checked = true;
                    CheckBox_LoginAutomático.Font = new Font("Tahoma", 10, FontStyle.Regular);
                    CheckBox_LoginAutomático.ForeColor = Color.White;
                    CheckBox_LoginAutomático.Location = new Point(90, 365);
                    CheckBox_LoginAutomático.Size = new Size(170, 16);
                    CheckBox_LoginAutomático.Text = "Entrar automaticamente";
                    this.Controls.Add(CheckBox_LoginAutomático);
                #endregion
            #endregion

            // Finalização dos objetos.
            #region
            this.BackColor = Color.FromArgb(46, 48, 61);
                PictureBox_Logotipo.Load(@"Skin\SendMe.skn");
            #endregion
        }

        protected void Button_Sair_Click(object sender, EventArgs e)
        {
            // Finalização do programa.
            #region
                Button Button_Sair = sender as Button;
                Application.Exit();
            #endregion
        }

        protected void Button_Minimizar_Cick(object sender, EventArgs e)
        {
            // Minimização do programa.
            #region
                Button Button_Minimizar = sender as Button;
                this.WindowState = FormWindowState.Minimized;
            #endregion
        }

        protected void TextBox_Senha_Click(object sender, EventArgs e)
        {
            // Limpeza parcial da TextBox - Senha.
            #region
            #endregion
        }

    }
}
