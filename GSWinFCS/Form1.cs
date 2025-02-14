using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSWinFCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Блокировка подозрнительных символов
            string allowSymb = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";

            if (!allowSymb.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginName_TextChanged(object sender, EventArgs e)
        {
            // Удаляем ненужные символы если пользователь вставил текст
            string allowSymb = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";

            string newLoginName = new string(loginName.Text.Where(c => allowSymb.Contains(c)).ToArray());

            if (loginName.Text != newLoginName)
            {
                int cursorPosition = loginName.SelectionStart;
                loginName.Text = newLoginName;
                loginName.SelectionStart = Math.Min(cursorPosition, loginName.Text.Length);
            }
        }
    }
}
