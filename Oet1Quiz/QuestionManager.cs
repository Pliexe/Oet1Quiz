using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Oet1Quiz
{
    public class Question {
        public int id;
        public string question;

        public string anwser1;
        public string anwser2;
        public string anwser3;

        public int correct;

        public Question(string _quesion, string _anwser1, string _anwser2, string _anwser3, int _correct)
        {
            question = _quesion;
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
    }

    public class QuestionManager
    {
        public Question[] questions;
        public bool randomize;
        public bool randomizeOnFail;
        public string category;

        public QuestionManager(Question[] _questions)
        {
            questions = _questions;
        }

        public void Randomize()
        {
            Random rng = new Random();
            for(int i = questions.Length - 1; i >= 1; i--)
            {
                int r = rng.Next(i);

                Question temp = questions[i];
                questions[i] = questions[r];
                questions[r] = temp;
            }
        }


        /*public delegate void ConnectedEventHandler(object sender, EventArgs args);
        public event ConnectedEventHandler Connected;
*/
        /*protected virtual void OnConnected()
        {
            if(Connected != null)
                Connected(this, EventArgs.Empty);
        }

        public Question[] questions;


        string connectionString = @"Data Source=DESKTOP-DBSU0SC\SQLEXPRESS;Initial Catalog=elektro_tehnika_alapjai;Integrated Security=True";

        public void Initialize()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to database");

                OnConnected();

                DataTable table = new DataTable();

                new SqlDataAdapter("SELECT * FROM alapok1", connection).Fill(table);


                questions = new Question[table.Rows.Count];

                for (int i = 0; i < questions.Length; i++)
                {
                    *//*Console.WriteLine($"{table.Rows[i].ItemArray.ElementAt(0)}: {table.Rows[i].ItemArray.ElementAt(1)}, {table.Rows[i].ItemArray.ElementAt(5)}");*//*
                    questions[i] = new Question(table.Rows[i].ItemArray.ElementAt(1).ToString(), table.Rows[i].ItemArray.ElementAt(2).ToString(), table.Rows[i].ItemArray.ElementAt(3).ToString(), table.Rows[i].ItemArray.ElementAt(4).ToString(), int.Parse(table.Rows[i].ItemArray.ElementAt(5).ToString())) { id = int.Parse(table.Rows[i].ItemArray.ElementAt(0).ToString()) };
                }

                connection.Close();

                foreach (Question question in questions)
                {
                    Console.WriteLine($"{question.id}");
                }
            }
            else
            {
                Console.WriteLine("Unsuccesful connection to db");
            }
        }*/
    }
}