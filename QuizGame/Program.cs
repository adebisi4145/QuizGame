using QuizGame;

Console.WriteLine("Welcome to the Fun Quiz Game!");

bool keepPlaying = true;

while (keepPlaying)
{
    Console.WriteLine("Press any key to start...");
    Console.ReadKey();

    int score = 0;

    var questions = new[]
    {
        new Question(
            "What is 9 + 10?",
            new[]
            {
                "A) 19",
                "B) 21",
                "C) 20",
                "D) 18"
            },
            'A'),

        new Question(
            "What does the `using` keyword do in C#?",
            new[]
            {
                "A) Declares a namespace",
                "B) Imports a namespace",
                "C) Declares a variable",
                "D) Terminates a program"
            },
            'B'),

        new Question(
            "Which type is NOT a value type in C#?",
            new[]
            {
                "A) int",
                "B) string",
                "C) float",
                "D) bool"
            },
            'B'),

        new Question(
            "What is the capital of France?",
            new[]
            {
                "A) Berlin",
                "B) Madrid",
                "C) Paris",
                "D) Rome"
            },
            'C'),

        new Question(
            "What is the default access modifier for a class in C#?",
            new[]
            {
                "A) Public",
                "B) Private",
                "C) Internal",
                "D) Protected"
            },
            'C'),

        new Question(
            "Which keyword is used to inherit a class in C#?",
            new[]
            {
                "A) implements",
                "B) extends",
                "C) inherits",
                "D) :"
            },
            'D')
    };

    foreach (var question in questions)
    {
        Console.Clear();
        Console.WriteLine(question.Text);
        foreach (var option in question.Options)
        {
            Console.WriteLine(option);
        }

        char answer = ' ';
        bool validAnswer = false;

        while (!validAnswer)
        {
            Console.WriteLine("Select your answer or press 'Q' to quit: ");
            answer = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (answer == 'Q')
            {
                Console.Clear();
                Console.WriteLine($"Quiz Over! Your current score is {score}/{questions.Length}");
                Console.WriteLine("Thanks for playing!");
                break; 
            }
            else if (answer == 'A' || answer == 'B' || answer == 'C' || answer == 'D')
            {
                validAnswer = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose from A, B, C, D, or Q to quit.");
            }
        }

        if (answer == 'Q')
            break;

        if (question.IsAnswerCorrect(answer))
        {
            Console.WriteLine("Yipee, you are correct!!!");
            score++;
        }
        else
        {
            Console.WriteLine("Oops, that's not right!");
        }

        Console.WriteLine("Press any key for the next question...");
        Console.ReadKey();
    }

    Console.Clear();
    if (score == questions.Length)
    {
        Console.WriteLine("Congratulations! You got a perfect score of 6/6");
        Console.WriteLine("You're a quiz champion!!!");
    }
    else
    {
        Console.WriteLine($"Quiz Over! Your final score is {score}/{questions.Length}");
    }

    Console.WriteLine("Would you like to play again? (Y/N)");

    char response = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if ( char.ToUpper(response) != 'Y')
    {
        keepPlaying = false;
        Console.WriteLine("Thanks for playing!");
    }
}
