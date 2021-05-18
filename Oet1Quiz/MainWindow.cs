using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oet1Quiz.questionMng;

namespace Oet1Quiz
{
    public partial class MainWindow : Form
    {
        int points = 0;

        QuestionManager questionManager = new QuestionManager();

        public MainWindow()
        {
            InitializeComponent();

            questionManager.Connected += (object sender, EventArgs e) =>
            {
                button_start.Enabled = true;
            };

            questionManager.Initialize(dataGridView2);
        }

        /*// Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }*/

        private void header_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void header_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void SwitchToMainMenu()
        {
            question_Panel.Visible = false;
            mainMenu_panel.Visible = true;
        }

        void SwitchToQuestionPanel()
        {
            question_Panel.Visible = true;
            mainMenu_panel.Visible = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Question question = questionManager.questions[0];
            question_label.Text = question.question;

            radioButton_question1.Text = question.anwser1;
            radioButton_question2.Text = question.anwser2;
            radioButton_question3.Text = question.anwser3;

            SwitchToQuestionPanel();
        }
    }
}
