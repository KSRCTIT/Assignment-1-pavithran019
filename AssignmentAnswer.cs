using System;

class Program
{
    static void Main()
    {
        // Call whichever function you want to test:
        //Q1_Literals();
        //Q2_Calculator();
        //Q3_ScoreComparison();
        //Q4_LoginSystem();
        //Q5_QuizPoints();
        //Q6_ElectionLoop();
        //Q7_ATMSystem();
        //Q8_MultiplicationTable();
        //Q9_ElectricityBill();
        //Q10_StudentMarks();
        //Q11_NameValidation();
    }

    // ---------------- 1. Literals & Data Types ----------------
    static void Q1_Literals()
    {
        // i) Temperature
        float temperature = 36.6f;
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine(temperature > 37.0f ? "Fever" : "Normal");

        // ii) Age check
        int age = 18;
        Console.WriteLine(age >= 18 ? "Eligible to Vote" : "Not Eligible");

        // iii) Gender
        char gender = 'M';
        if (gender == 'M') Console.WriteLine("Male");
        else if (gender == 'F') Console.WriteLine("Female");
        else Console.WriteLine("Other");

        // iv) Price & discount
        double price = 1000.0, discount = 10.0;
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);

        // v) Bool literal
        bool isLogin = true;
        Console.WriteLine(isLogin ? "Login successful" : "Access denied");

        // vi) Print values with data type
        int age2 = 25;
        float temp2 = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"{age2} → {age2.GetType()}");
        Console.WriteLine($"{temp2} → {temp2.GetType()}");
        Console.WriteLine($"{grade} → {grade.GetType()}");
        Console.WriteLine($"{isPassed} → {isPassed.GetType()}");
    }

    // ---------------- 2. Calculator for Kids ----------------
    static void Q2_Calculator()
    {
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages copied: " + (a * b));
        Console.WriteLine("Chocolates per kid: " + (a / b));
        Console.WriteLine("Leftover candies: " + (a % b));
    }

    // ---------------- 3. Player Scores ----------------
    static void Q3_ScoreComparison()
    {
        int A = 20, B = 15;
        Console.WriteLine("A > B? " + (A > B));
        Console.WriteLine("A == B? " + (A == B));
        Console.WriteLine("A <= B? " + (A <= B));
        Console.WriteLine("A >= B? " + (A >= B));
    }

    // ---------------- 4. Login System ----------------
    static void Q4_LoginSystem()
    {
        string username = "admin", password = "1234";
        string u = "admin", p = "1234"; // Sample input

        if (u == username && p == password)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one correct? " + (u == username || p == password));
        Console.WriteLine("Opposite of granted: " + !(u == username && p == password));
    }

    // ---------------- 5. Quiz Points ----------------
    static void Q5_QuizPoints()
    {
        int score = 50;
        Console.WriteLine("Start Score: " + score);

        score += 10;  // correct
        Console.WriteLine("After Correct: " + score);

        score -= 5;   // wrong
        Console.WriteLine("After Wrong: " + score);

        score *= 2;   // bonus
        Console.WriteLine("After Bonus: " + score);

        score /= 5;   // penalty
        Console.WriteLine("After Penalty: " + score);
    }

    // ---------------- 6. Election Eligibility Loop ----------------
    static void Q6_ElectionLoop()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age of person " + i + ": ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age >= 18 ? "Eligible to Vote" : "Not Eligible");
        }
    }

    // ---------------- 7. ATM PIN System ----------------
    static void Q7_ATMSystem()
    {
        int pin = 1234;
        bool access = false;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter PIN: ");
            int entered = int.Parse(Console.ReadLine());

            if (entered == pin)
            {
                Console.WriteLine("Access Granted");
                access = true;
                break;
            }
            else
                Console.WriteLine("Wrong PIN. Try again.");
        }

        if (!access)
            Console.WriteLine("Card Blocked");
    }

    // ---------------- 8. Multiplication Table ----------------
    static void Q8_MultiplicationTable()
    {
        char choice = 'Y';
        while (choice == 'Y' || choice == 'y')
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");

            Console.Write("Do you want another table? (Y/N): ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
    }

    // ---------------- 9. Electricity Bill ----------------
    static void Q9_ElectricityBill()
    {
        Console.Write("Enter units: ");
        int units = int.Parse(Console.ReadLine());
        int bill = 0;

        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = (100 * 2) + (units - 100) * 3;
        else
            bill = (100 * 2) + (100 * 3) + (units - 200) * 5;

        Console.WriteLine("Total Bill: ₹" + bill);
    }

    // ---------------- 10. Student Marks ----------------
    static void Q10_StudentMarks()
    {
        int[] marks = new int[5];
        Console.WriteLine("Enter 5 subject marks:");
        for (int i = 0; i < 5; i++)
            marks[i] = int.Parse(Console.ReadLine());

        double avg = 0;
        foreach (int m in marks) avg += m;
        avg /= 5;

        Console.WriteLine("Average: " + avg);
        Console.WriteLine(avg >= 40 ? "Passed" : "Failed");
    }

    // ---------------- 11. Name Validation ----------------
    static void Q11_NameValidation()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        bool isValid = true;

        foreach (char c in name)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                isValid = false;
                break;
            }
        }

        Console.WriteLine(isValid ? "Valid Name" : "Invalid Name");
    }
}
