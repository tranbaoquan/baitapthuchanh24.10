using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;

        public LoginForm()
        {
            // Tạo các thành phần trên form
            this.Text = "Login Form";

            Label lblUsername = new Label() { Text = "Tên đăng nhập", Top = 20, Left = 30 };
            Label lblPassword = new Label() { Text = "Mật khẩu", Top = 60, Left = 30 };

            txtUsername = new TextBox() { Top = 20, Left = 150, Width = 150 };
            txtPassword = new TextBox() { Top = 60, Left = 150, Width = 150, UseSystemPasswordChar = true };

            btnLogin = new Button() { Text = "Đăng nhập", Top = 100, Left = 150 };
            btnExit = new Button() { Text = "Thoát", Top = 100, Left = 250 };

            btnLogin.Click += new EventHandler(BtnLogin_Click);
            btnExit.Click += new EventHandler(BtnExit_Click);

            this.Controls.Add(lblUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnExit);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 400;
            this.Height = 200;
        }

        // Sự kiện khi nhấn nút Đăng nhập
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        // Sự kiện khi nhấn nút Thoát
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}
