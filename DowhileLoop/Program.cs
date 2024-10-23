{
    string correctCode = "13579";
    string userInput;
    int attempt = 0;
    int maxAttempt = 5;

    do
    {
        Console.WriteLine("Please enter the correct key code.");
        userInput = Console.ReadLine();
        attempt++;
        {
            if (userInput == correctCode)
            {
                Console.WriteLine("Access Granted. Welcome!");
                break;
            }
            if (userInput != correctCode && attempt <= maxAttempt)
            {
                Console.WriteLine("Incorrect code. You have " + (maxAttempt - attempt) + " attempts remaining.");
            }
            if (userInput != correctCode && attempt >= maxAttempt)
            {
                Console.WriteLine("Warning. There were too many incorrect attempts. You can still try one last time to enter the correct code for access.");
                userInput = Console.ReadLine();
                {
                    if (userInput == correctCode)
                    {
                        Console.WriteLine("Access granted. Welcome!");
                    }
                    if (userInput != correctCode)
                    {
                        Console.WriteLine("You have exhausted all attempts.");
                        break;
                    }
                }
            }
          
        }
    } while (userInput != correctCode);
}

// Can you briefly explain how to use loops to keep your program running as long as needed? 

// Your choice of loop (and under what condition) will impact how long your program continues to run:
// While loop: Tests the condition before running, and will continue to run as long as the condition remains true.
// Do-while loop: Tests the condition at the end of the loop body. It will only repeat if the condition remains true. Do-while loops are guarenteed to run at least once.
// For loop: Executes a sequence of code a specific number of times and makes changes to the loop variable if applicable.