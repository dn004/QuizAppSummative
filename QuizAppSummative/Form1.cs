using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizAppSummative
{
    /// <summary>
    /// Represents the main form of the quiz application.
    /// </summary>
    public partial class Form1 : Form
{
    // necessary variables
    private int correctAnswer;
    private int questionNumber = 0;
    private int score;
    private int totalQuestions;

    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        InitializeComponent();

        askQuestions(questionNumber);
        totalQuestions = 8;
    }

    /// <summary>
    /// Handles the click event of the first button.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (questionNumber == 0)
            {
                questionNumber++;
                askQuestions(questionNumber);
            }
        }
        catch (Exception ex)
        {
            HandleException(ex);
        }
    }

    /// <summary> /// Handles the click event of the answer buttons.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void checkAnswer(object sender, EventArgs e)
    {
        try
        {
            if (sender is Button senderButton) // Check if the sender is a Button
            {
                int buttonTag = Convert.ToInt32(senderButton.Tag);

                Console.WriteLine($"Button {buttonTag} clicked for question {questionNumber}");

                string userAnswer = "";

                if (questionNumber > 0)
                {
                    // Get the text of the selected answer
                    userAnswer = senderButton.Text;

                    if (buttonTag == correctAnswer)
                    {
                        score++;
                        // Provide immediate feedback
                        MessageBox.Show($"Correct! The correct answer is {userAnswer}.");
                    }
                    else
                    {
                        // Get the name of the correct answer
                        string correctAnswerText = askQuestions(questionNumber);
                        // Provide immediate feedback
                        MessageBox.Show($"Wrong! The correct answer is {correctAnswerText}. You selected {userAnswer}.");
                    }
                }

                if (questionNumber == totalQuestions - 1)
                {
                    // work out the percentage
                    int percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                    MessageBox.Show(
                        "Quiz Ended!" + Environment.NewLine +
                        "You have answered " + score + " questions correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click OK to play again"
                    );
                    score = 0;
                    questionNumber = 0;
                    askQuestions(questionNumber);
                }
                else
                {
                    questionNumber++;
                    askQuestions(questionNumber);
                }
            }
        }
        catch (Exception ex)
        {
            HandleException(ex);
        }
    }

    /// <summary>
    /// Helper method to get the text of the answer based on the option number.
    /// </summary>
    /// <param name="questNum">The question number.</param>
    /// <returns>The text of the answer.</returns>
    private string askQuestions(int questNum)
    {
        try
        {
            switch (questNum)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.quiz_time;
                    quizQuestion.Text = "Pick a Topic";
                    button1.Text = "Movies";
                    button2.Text = "Science";
                    button3.Text = "Animals";
                    button4.Text = "Technology";
                    button5.Text = "Cars";
                    button6.Text = "Countries";

                    // Use Tag property to set correct answer
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    button5.Tag = 5;
                    button6.Tag = 6;

                    correctAnswer = 1;
                    return "Movies";

                    case 1:
                        pictureBox1.Image = Properties.Resources.quentin_tarantino;
                        quizQuestion.Text = "Who directed the 1994 classic 'Pulp Fiction'?";
                        button1.Text = "Martin Scorsese";
                        button2.Text = "David Fincher";
                        button3.Text = "David Lynch";
                        button4.Text = "Quentin Tarantino";
                        button5.Text = "Wes Anderson";
                        button6.Text = "Christopher Nolan";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 4;
                        return "Quentin Tarantino";

                    case 2:
                        pictureBox1.Image = Properties.Resources.Japan;
                        quizQuestion.Text = "Where is the movie 'Bullet Train' set?";
                        button1.Text = "Italy";
                        button2.Text = "Japan";
                        button3.Text = "Prague";
                        button4.Text = "France";
                        button5.Text = "Greece";
                        button6.Text = "Costa Rica";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 2;
                        return "Japan";

                    case 3:
                        pictureBox1.Image = Properties.Resources.Clarice_Starling;
                        quizQuestion.Text = "What is the name of the female lead in the thriller 'Silence of the lamb'?";
                        button1.Text = "Ardelia Mapp";
                        button2.Text = "Marcy Madsen";
                        button3.Text = "Clarice Starling";
                        button4.Text = "Miriam Lass";
                        button5.Text = "Judy Hopps";
                        button6.Text = "Catherine Martin";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 3;
                        return "Clarice Starling";

                    case 4:
                        pictureBox1.Image = Properties.Resources.pierce_brosnan;
                        quizQuestion.Text = "What is the name of this James Bond?";
                        button1.Text = "Timothy Dalton";
                        button2.Text = "Roger Moore";
                        button3.Text = "Matthew McCognauhey";
                        button4.Text = "Sean Connery";
                        button5.Text = "Daniel Craig";
                        button6.Text = "Pierce Brosnan";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 6;
                        return "Pierce Brosnan";

                    case 5:
                        pictureBox1.Image = Properties.Resources.heath_ledger;
                        quizQuestion.Text = "Who portrayed Joker in the 2008 classic 'Dark Knight'?";
                        button1.Text = "Jared Leto";
                        button2.Text = "Jack Nicholson";
                        button3.Text = "Joaquin Phoenix";
                        button4.Text = "Mark Hamil";
                        button5.Text = "Heath Ledger";
                        button6.Text = "Robert Downey Jr";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 5;
                        return "Heath Ledger";

                    case 6:
                        pictureBox1.Image = Properties.Resources.martin_scorcesse;
                        quizQuestion.Text = "Who directed the iconic mob thriller 'GoodFellas'?";
                        button1.Text = "Francis Ford Capolla";
                        button2.Text = "Martin Scorcesese";
                        button3.Text = "Quentin Tarantino";
                        button4.Text = "Steven Spielberg";
                        button5.Text = "Christopher Nolan";
                        button6.Text = "Brian De Palma";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 2;
                        return "Martin Scorcesese";

                    case 7:
                        pictureBox1.Image = Properties.Resources.you_do_not_talk_about_fight_club;
                        quizQuestion.Text = "What movie is this picture from?";
                        button1.Text = "Inside Out";
                        button2.Text = "GodFather";
                        button3.Text = "Gone Girl";
                        button4.Text = "Hoops and Boobs";
                        button5.Text = "Training Day";
                        button6.Text = "Fight Club";

                        // Use Tag property to set correct answer
                        button1.Tag = 1;
                        button2.Tag = 2;
                        button3.Tag = 3;
                        button4.Tag = 4;
                        button5.Tag = 5;
                        button6.Tag = 6;

                        correctAnswer = 6;
                        return "Fight Club";



                    default:
                        return ""; // Handle default case appropriately
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return ""; // Handle the case when an exception occurs in askQuestions
            }
        }

        /// <summary>
        /// Handles exceptions by showing an error message.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private void HandleException(Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
