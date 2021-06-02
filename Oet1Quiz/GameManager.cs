using System;
using System.Diagnostics;
using System.Windows.Forms;
using ZsoltCustomElements;

namespace Oet1Quiz
{
    public class GameManager
    {
        public delegate void GameEndedEventHandler();
        public event GameEndedEventHandler GameEnded;

        Panel correctPanel;
        Panel incorrectPanel;
        Panel endGamePanel;

        Label questionLabel;
        ResizeableRadioButton anwser1;
        ResizeableRadioButton anwser2;
        ResizeableRadioButton anwser3;

        PictureBox pictureBox;
        PictureBox smilePictureBox;
        Label pontSzam;
        Label endPontSzam;
        Label correctQuestionLabel;
        Label timeElapsedLabel;

        QuestionManager questionManager = null;

        int currentQuestion = 0;

        int pont = 0;

        Stopwatch clock = new Stopwatch();

        public GameManager(Label _questionLabel, ResizeableRadioButton _anwser1, ResizeableRadioButton _anwser2, ResizeableRadioButton _anwser3, Label _timeElapsedLabel, Label _correctQuestionLabel, Button backToMenu, Panel _endGamePanel, Label _endPontSzam, Label _pontSzam, PictureBox _smilePictureBox, Button _giveAnwserButton, Button _nextCorrBtn, Button _nextIncBtn, PictureBox _pictureBox, Panel _correctPanel, Panel _incorrectPanel)
        {
            clock.Restart();

            questionLabel = _questionLabel;
            timeElapsedLabel = _timeElapsedLabel;

            anwser1 = _anwser1;
            anwser2 = _anwser2;
            anwser3 = _anwser3;

            endPontSzam = _endPontSzam;
            correctQuestionLabel = _correctQuestionLabel;

            pictureBox = _pictureBox;

            smilePictureBox = _smilePictureBox;
            pontSzam = _pontSzam;

            incorrectPanel = _incorrectPanel;
            correctPanel = _correctPanel;
            endGamePanel = _endGamePanel;

            _giveAnwserButton.Click += OnAnwser;

            _nextCorrBtn.Click += (object sender, EventArgs e) => _correctPanel.Visible = false;
            _nextIncBtn.Click += (object sender, EventArgs e) => _incorrectPanel.Visible = false;
            backToMenu.Click += (object sender, EventArgs e) => {
                questionManager = null;
                currentQuestion = 0;
                pont = 0;
                endGamePanel.Visible = false;
                GameEnded?.Invoke();
            };
        }

        public void StartGame(QuestionManager _questionManager, Panel questionPanel, Panel mainMenu)
        {
            questionManager = _questionManager;

            if (questionManager.randomize) questionManager.Randomize();
            SetupQuestion();
            questionPanel.Visible = true;
            mainMenu.Visible = false;
        }

        void OnAnwser(object sender, EventArgs e)
        {
            if (questionManager == null) return;

            if(isNeutral())
            {
                currentQuestion++;
                pont--;
                smilePictureBox.Image = Properties.Resources.sad;
                pontSzam.Text = $"Pont szám: {pont}";
                correctQuestionLabel.Text = "Átugorva!";
                correctPanel.Visible = true;
                SetupQuestion();

                return;
            }


            if (isCorrect())
            {
                currentQuestion++;
                pont++;
                smilePictureBox.Image = Properties.Resources.smile;
                pontSzam.Text = $"Pont szám: {pont}";
                correctQuestionLabel.Text = "Pontos válasz!";
                correctPanel.Visible = true;
                SetupQuestion();
            }
            else
            {
                if (questionManager.randomizeOnFail) questionManager.Randomize();
                currentQuestion = 0;
                incorrectPanel.Visible = true;
                SetupQuestion();
            }
        }

        bool isNeutral()
        {
            if (questionManager.questions[currentQuestion].neutral == null) return false;
            else
            if (anwser1.Checked) return questionManager.questions[currentQuestion].isNeutral(1);
            else if (anwser2.Checked) return questionManager.questions[currentQuestion].isNeutral(2);
            else if (anwser3.Checked) return questionManager.questions[currentQuestion].isNeutral(3);
            else return false;
        }

        bool isCorrect()
        {
            if (anwser1.Checked) return questionManager.questions[currentQuestion].isCorrect(1);
            else if (anwser2.Checked) return questionManager.questions[currentQuestion].isCorrect(2);
            else if (anwser3.Checked) return questionManager.questions[currentQuestion].isCorrect(3);
            else return false;
        }

        void ResetSelections()
        {
            anwser1.Checked = false;
            anwser2.Checked = false;
            anwser3.Checked = false;
        }

        void SetupQuestion()
        {
            ResetSelections();

            if (currentQuestion >= questionManager.questions.Count)
            {
                clock.Stop();
                endPontSzam.Text = $"Pont szám: {pont}/{questionManager.questions.Count}";

                timeElapsedLabel.Text = $"Eltartot idő: {(int)Math.Floor(clock.Elapsed.TotalHours)}:{(clock.Elapsed.Minutes < 10 ? "0" : "")}{clock.Elapsed.Minutes}:{(clock.Elapsed.Seconds < 10 ? "0" : "")}{clock.Elapsed.Seconds}";
                endGamePanel.Visible = true;
                return;
            }

            if (questionManager.questions[currentQuestion].image != null) pictureBox.Image = questionManager.questions[currentQuestion].image;
            else if (pictureBox.Image != null) pictureBox.Image = null;

            questionLabel.Text = questionManager.questions[currentQuestion].question;

            anwser1.Text = questionManager.questions[currentQuestion].anwser1;
            anwser2.Text = questionManager.questions[currentQuestion].anwser2;
            anwser3.Text = questionManager.questions[currentQuestion].anwser3;
        }
    }
}
