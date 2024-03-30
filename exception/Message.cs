using System.Windows.Forms;

namespace ProjectCS.exception
{
    public class Message 
    {
        private Message()
        {
        }

        public static void MessageInfo(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public static void MessageError(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}