using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class Question
    {
        public string Text { get; set; } // The question text
    public string[] Options { get; set; } // The multiple-choice options
    public char CorrectOption { get; set; } // The correct answer (e.g., 'A', 'B', 'C', 'D')

    public Question(string text, string[] options, char correctOption)
    {
        Text = text;
        Options = options;
        CorrectOption = correctOption;
    }

    public bool IsAnswerCorrect(char userAnswer)
    {
        return char.ToUpper(userAnswer) == CorrectOption;
    }
    }
}
