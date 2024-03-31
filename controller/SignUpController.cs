using System;
using System.Windows.Forms;
using ProjectCS.exception;
using ProjectCS.model;
using ProjectCS.service;
using ProjectCS.utils.factory;
using Message = ProjectCS.exception.Message;

namespace WindowsFormsApplication1
{
    public partial class SignUpController : Form
    {
        private readonly UserService _userService;
        private readonly ContainerUtils _containerUtils;
        public SignUpController(ContainerUtils containerUtils)
        {
            _containerUtils = containerUtils;
            _userService = containerUtils.UserService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (String.IsNullOrEmpty(username))
            {
                Message.MessageError("invalid username");
                return;
            }
            if (String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword) || confirmPassword != password) 
            {
                Message.MessageError("invalid password");
                return;
            }

            User user = new User(username, password);
            try
            {
                User userCreated = _userService.signUp(user);
                //use threads in order to not block every window after opening a new one
                var threadParameters = new System.Threading.ThreadStart(delegate { openNewMainWindow(user); });
                var thread = new System.Threading.Thread(threadParameters);
                thread.Start();
                this.Close();
            }
            catch(ServiceException ex)
            {
                Message.MessageError(ex.Message);
            }
        }

        private void openNewMainWindow(User userCreated)
        {
            MainController mainController = new MainController(_containerUtils,userCreated);
            mainController.Text = userCreated.Username;
            mainController.Tag = userCreated.Id;
            mainController.ShowDialog();
        }
    }
}