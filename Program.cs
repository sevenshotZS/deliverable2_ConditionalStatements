/*
 * Author: Zack S.
 * Date: 1/24/23
 * Description: C# Console Applications for assigning letter grade with a certain score.
 * */


    Console.WriteLine("Enter your numeric grade for ISM 4300 or another class: ");

    try
    {

        decimal grade = decimal.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("Your expected letter grade for the course is an A");
        }

        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
            Console.WriteLine("Your expected letter grade for the course is a B");
        }

        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
            Console.WriteLine("Your expected letter grade for the course is a C");
        }

        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
            Console.WriteLine("Your expected letter grade for the course is a D");
        }

        else if (grade >= 0 && grade < 60)
        {
            letter = "F";
            Console.WriteLine("Your expected letter grade for the course is an F");
        }

    }
    catch
    {
        Console.WriteLine("Enter your numeric grade for ISM 4300 or another class: ");
    }

    Console.WriteLine("");
