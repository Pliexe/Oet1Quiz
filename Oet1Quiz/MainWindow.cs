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
        int currentQuestion = 0;

        QuestionManager questionManager = new QuestionManager();

        public MainWindow()
        {
            InitializeComponent();

            dataGridView2.ForeColor = Color.Black;

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

        void SetupQuestion(Question question)
        {
            question_label.Text = question.question;

            radioButton_question1.Text = question.anwser1;
            radioButton_question2.Text = question.anwser2;
            radioButton_question3.Text = question.anwser3;
        }

        void ResetSelections()
        {
            radioButton_question1.Checked = false;
            radioButton_question2.Checked = false;
            radioButton_question3.Checked = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            SetupQuestion(questionManager.questions[0]);

            SwitchToQuestionPanel();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Question question = questionManager.questions[currentQuestion];

            int selected;

            if (radioButton_question1.Checked) selected = 1;
            else if (radioButton_question2.Checked) selected = 2;
            else if (radioButton_question3.Checked) selected = 3;
            else {
                MessageBox.Show("Returned");
                return;
            };

            if(question.isCorrect(selected))
            {
                currentQuestion++;
                if(currentQuestion < questionManager.questions.Length)
                {
                    ResetSelections();
                    SetupQuestion(questionManager.questions[currentQuestion]);
                } else
                {
                    currentQuestion = 0;
                    SwitchToMainMenu();
                }
            } else
            {
                MessageBox.Show("Rosz valasz");
            }
        }
    }
}
