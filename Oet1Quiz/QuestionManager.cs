using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Collections.Generic;

namespace Oet1Quiz
{
    public class Question {
        public string question;
        public Image image;

        public string anwser1;
        public string anwser2;
        public string anwser3;

        public int? neutral;

        public int correct;

        public Question(string _quesion, string _anwser1, string _anwser2, string _anwser3, int _correct)
        {
            question = _quesion;
            anwser1 = _anwser1;
            anwser2 = _anwser2;
            anwser3 = _anwser3;
            correct = _correct;
        }

        public Question(string _quesion, Image _image, string _anwser1, string _anwser2, string _anwser3, int _correct)
        {
            question = _quesion;
            image = _image;
            anwser1 = _anwser1;
            anwser2 = _anwser2;
            anwser3 = _anwser3;
            correct = _correct;
        }

        public bool isCorrect(string anwser)
        {
            return anwser == anwser1 ? correct == 1 : (anwser == anwser2 ? correct == 2 : (anwser == anwser3 && correct == 3));
        }

        public bool isCorrect(int selected)
        {
            return correct == selected;
        }

        public bool isNeutral(int selected)
        {
            if (neutral == null) return false;
            return neutral == selected;
        }
    }

    public class QuestionManager
    {
        public List<Question> questions { get; private set; }

        public bool randomize;
        public bool randomizeOnFail;
        public string category;

        Random rng = new Random();

        public QuestionManager(PredetermenedQuestion[] predetermenedQuestions, CorrectTextQuestion[] correctTextQuestions, CorrectImageQuestion[] correctImageQuestions)
        {
            questions = new List<Question>();

            if (predetermenedQuestions != null)
            {
                foreach (PredetermenedQuestion predetermenedQuestion in predetermenedQuestions)
                {
                    if (predetermenedQuestion.imagePath == null)
                    {
                        questions.Add(new Question(predetermenedQuestion.question, predetermenedQuestion.anwser1, predetermenedQuestion.anwser2, predetermenedQuestion.anwser3, predetermenedQuestion.correct) { neutral = predetermenedQuestion.neutral });
                    }
                    else
                    {
                        try
                        {
                            questions.Add(new Question(predetermenedQuestion.question, Image.FromFile(predetermenedQuestion.imagePath), predetermenedQuestion.anwser1, predetermenedQuestion.anwser2, predetermenedQuestion.anwser3, predetermenedQuestion.correct) { neutral = predetermenedQuestion.neutral });
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
            }

            if (correctTextQuestions != null)
            {
                IEnumerable<string> anwsers = correctTextQuestions.Select(cTQ => cTQ.correctAnwser);

                foreach (CorrectTextQuestion correctTextQuestion in correctTextQuestions)
                {
                    int correct = rng.Next(1, 4);

                    string an1 = null;
                    string an2 = null;
                    string an3 = null;

                    switch (correct)
                    {
                        case 1:
                            an1 = correctTextQuestion.correctAnwser;
                            break;
                        case 2:
                            an2 = correctTextQuestion.correctAnwser;
                            break;
                        case 3:
                            an3 = correctTextQuestion.correctAnwser;
                            break;
                    }

                    if (an1 == null) an1 = getRandom(anwsers, correctTextQuestion.correctAnwser);

                    if (an2 == null)
                    {
                        if (an3 == null) an2 = getRandom(anwsers, correctTextQuestion.correctAnwser);
                        else an2 = getRandom(anwsers, correctTextQuestion.correctAnwser, an1);
                    }

                    if (an3 == null) an3 = getRandom(anwsers, an2, an1);

                    if (correctTextQuestion.imagePath == null)
                        questions.Add(new Question(correctTextQuestion.question, an1, an2, an3, correct));
                    else
                    {
                        try
                        {
                            questions.Add(new Question(correctTextQuestion.question, Image.FromFile(correctTextQuestion.imagePath), an1, an2, an3, correct));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
            }

            if(correctImageQuestions != null)
            {
                IEnumerable<string> paths = correctImageQuestions.Select(cIQ => cIQ.imagePath);

                List<Question> temp = new List<Question>();

                foreach(CorrectImageQuestion correctImageQuestion in correctImageQuestions)
                {
                    try
                    {
                        temp.Add(new Question(correctImageQuestion.question, Image.FromFile(correctImageQuestion.imagePath) , "Igen", "Nem", "Nem tudom", 1) { neutral = 3 });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }

                questions = questions.Concat(randomizeImages(temp)).ToList();
            }
        }

        private List<Question> randomizeImages(List<Question> qs)
        {
            for (int i = 0; i < qs.Count / 2; i++)
            {
                if(qs[i].correct == 1)
                {
                    if(rng.Next(2) == 1)
                    {
                        qs[i].correct = 2;

                        Question random = getRandom(qs, i + 1);
                        random.correct = 2;

                        Image oldImg = qs[i].image;

                        qs[i].image = random.image;
                        random.image = oldImg;
                    }
                }
            }

            return qs;
        }

        public T getRandom<T>(List<T> enu, int fromIndex) where T : class
        {
            T rngElement = enu.ElementAt(rng.Next(fromIndex, enu.Count()));

            return rngElement;
        }

        public T getRandom<T>(IEnumerable<T> enu, T notAllowed) where T : class
        {
            T rngElement = enu.ElementAt(rng.Next(enu.Count()));

            if (rngElement == notAllowed) return getRandom(enu, notAllowed);

            return rngElement;
        }

        public T getRandom<T>(IEnumerable<T> enu, T notAllowed, T notAllowed2) where T : class
        {
            T rngElement = enu.ElementAt(rng.Next(enu.Count()));

            if (rngElement == notAllowed || rngElement == notAllowed2) return getRandom(enu, notAllowed, notAllowed2);

            return rngElement;
        }

        public void Randomize()
        {
            Random rng = new Random();
            for (int i = questions.Count - 1; i >= 1; i--)
            {
                int r = rng.Next(i);

                Question temp = questions[i];
                questions[i] = questions[r];
                questions[r] = temp;
            }
        }
    }
}