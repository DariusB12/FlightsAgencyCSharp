using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ProjectCS.model;
using ProjectCS.service;
using ProjectCS.utils.factory;
using Message = ProjectCS.exception.Message;

namespace WindowsFormsApplication1
{
        public partial class SignInController : Form1
        {
                private readonly ContainerUtils _containerUtils;
                private readonly UserService _userService;
                public SignInController(ContainerUtils containerUtils):base()
                {
                        _containerUtils = containerUtils;
                        _userService = containerUtils.UserService;
                        InitializeComponent();
                }

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        this.buttonSignIn = new System.Windows.Forms.Button();
                        this.buttonSignUp = new System.Windows.Forms.Button();
                        this.label1 = new System.Windows.Forms.Label();
                        this.textBoxUsername = new System.Windows.Forms.TextBox();
                        this.textBoxPassword = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // buttonSignIn
                        // 
                        this.buttonSignIn.Location = new System.Drawing.Point(61, 256);
                        this.buttonSignIn.Name = "buttonSignIn";
                        this.buttonSignIn.Size = new System.Drawing.Size(115, 64);
                        this.buttonSignIn.TabIndex = 0;
                        this.buttonSignIn.Text = "SignIn";
                        this.buttonSignIn.UseVisualStyleBackColor = true;
                        this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
                        // 
                        // buttonSignUp
                        // 
                        this.buttonSignUp.Location = new System.Drawing.Point(212, 261);
                        this.buttonSignUp.Name = "buttonSignUp";
                        this.buttonSignUp.Size = new System.Drawing.Size(118, 59);
                        this.buttonSignUp.TabIndex = 1;
                        this.buttonSignUp.Text = "SignUp";
                        this.buttonSignUp.UseVisualStyleBackColor = true;
                        this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
                        // 
                        // label1
                        // 
                        this.label1.Location = new System.Drawing.Point(156, 26);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(108, 45);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Welcome to FlightsApp";
                        // 
                        // textBoxUsername
                        // 
                        this.textBoxUsername.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.textBoxUsername.Location = new System.Drawing.Point(95, 137);
                        this.textBoxUsername.Name = "textBoxUsername";
                        this.textBoxUsername.Size = new System.Drawing.Size(222, 29);
                        this.textBoxUsername.TabIndex = 3;
                        this.textBoxUsername.Tag = "";
                        // 
                        // textBoxPassword
                        // 
                        this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.textBoxPassword.Location = new System.Drawing.Point(95, 195);
                        this.textBoxPassword.Name = "textBoxPassword";
                        this.textBoxPassword.PasswordChar = '*';
                        this.textBoxPassword.Size = new System.Drawing.Size(222, 29);
                        this.textBoxPassword.TabIndex = 4;
                        // 
                        // label2
                        // 
                        this.label2.Location = new System.Drawing.Point(165, 110);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(86, 24);
                        this.label2.TabIndex = 5;
                        this.label2.Text = "Username";
                        // 
                        // label3
                        // 
                        this.label3.Location = new System.Drawing.Point(165, 169);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(86, 23);
                        this.label3.TabIndex = 6;
                        this.label3.Text = "Password";
                        this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        // 
                        // SignInController
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                        this.ClientSize = new System.Drawing.Size(408, 366);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.textBoxPassword);
                        this.Controls.Add(this.textBoxUsername);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.buttonSignUp);
                        this.Controls.Add(this.buttonSignIn);
                        this.Name = "SignInController";
                        this.ResumeLayout(false);
                        this.PerformLayout();
                }

                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label label3;

                private System.Windows.Forms.TextBox textBoxUsername;
                private System.Windows.Forms.TextBox textBoxPassword;

                private System.Windows.Forms.Label label1;

                private System.Windows.Forms.Button buttonSignUp;

                private System.Windows.Forms.Button buttonSignIn;


                private void buttonSignIn_Click(object sender, EventArgs e)
                {
                        string username = textBoxUsername.Text;
                        string password = textBoxPassword.Text;
                        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                        {
                                Message.MessageError("Invalid username or password\n");
                                return;
                        }
                        try
                        {
                                User user = _userService.signIn(username, password);
                                
                                //use threads in order to not block every window after opening a new one
                                var threadParameters = new System.Threading.ThreadStart(delegate { openNewMainWindow(user); });
                                var thread = new System.Threading.Thread(threadParameters);
                                thread.Start();

                        }
                        catch(ApplicationException ex)
                        {
                                Message.MessageError(ex.Message);
                        }

                }

                public void openNewMainWindow(User user)
                {
                        MainController mainController = new MainController(_containerUtils,user);
                        mainController.Text = user.Username;
                        mainController.ShowDialog();
                }

                private void buttonSignUp_Click(object sender, EventArgs e)
                {
                        throw new System.NotImplementedException();
                }
        }
}