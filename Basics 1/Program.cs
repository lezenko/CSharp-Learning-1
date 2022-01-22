// See https://aka.ms/new-console-template for more information
// Random generator for computers number. It is set once but can be repeated in the do while loop to change.
Random rand = new Random();
int cpuNum = rand.Next(1,10);
// -99 Set as default. As the rules will only allow a number between 1 - 10.
int userNum = -99; 
// total attempts you will get.
int attempts = 3;
// set as a default value to check input against wrong input characters.

Console.WriteLine("Welcome to Snap Bang!");
Console.WriteLine("3 Attempts. If you match me, you win.");



for (int i = 3; i > 0; i--) //Will loop 3 times, same amount of times as attempts)
{
    // Get the user input, check if it can be parsed into integer. if it can, assign to usernum.
    Console.WriteLine("Enter number:");
    string val = Console.ReadLine();
    bool x = int.TryParse(val, out userNum);
    // if the user number and cpu number dont match, then we look at why.
    if (userNum != cpuNum) {
        
        if (x == true && attempts > 0) // is it parsed and are the attempts greater than 0? if so then loop
        {
            // is the number between 1 and 2? if not, another loop needs to take place with an increment i++
            if (userNum > 10 || userNum < 1)
            {
                i++;
                Console.WriteLine("Number is not between 1 & 10.");
            }
            else { 
             // everything is parsed, the input is correct, remove an attempt and let the loop continue 
            Console.WriteLine("You entered " + userNum);
            attempts--;
            Console.WriteLine("{0} Attempts Left.", attempts);
        }
            if (attempts == 0) // at this point user has run out of attempts. break the loop.
            {
                Console.WriteLine("You lost. Game. Over.");
                break;
            }
        }
        // if the user never entered a number, but rather a string. then once again an attept must be given back and another iteration of the loop to proceed.
        else
        {
            i++;
            Console.WriteLine("You didn't enter a number, try again.");
        }
    }
    // if the user has matched the cpu and the attempts are above 0 then user wins and the loop can break.
    else if (userNum == cpuNum && attempts > 0)
    {
        Console.WriteLine("You win!");
        break;
    }
}




