using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating 2 arrays containing usernames and passwords
            string[] userNames = new string[10];
            string[] userPassWords = new string[10];

            // hard coding usernames
            userNames[0] = "bo";
            userNames[1] = "lars";
            userNames[2] = "ole";
            userNames[3] = "biver";
            userNames[4] = "basse";

            // hard coding passwords
            userPassWords[0] = "bo";
            userPassWords[1] = "lars";
            userPassWords[2] = "ole";
            userPassWords[3] = "biver";
            userPassWords[4] = "basse";

            // my vars a string taking in input from a user put into the username same with password also a int counting the login tries
            string userName;
            string passWord;
            int loginTries = 0;

            // takes in the user input and put it into the username
            Console.WriteLine("please type in your username");
            userName = Console.ReadLine();

            // a while loop that checks if login tries are less then 3 if so it will check the username you typed in if wrong it adds 1 to loginTries
            while (loginTries < 3)
            {
                // a for loop that checks the lenght of the array
                for (int i = 0; i < userNames.Length; i++)
                {
                    // if the username matches of the usernames in the array it goes further in to the ask you for your password
                    if (userName == userNames[i])
                    {
                        // if the passwords matches it logs you in else it loops backaround to ask you for the username again
                        Console.WriteLine("please type in your password");
                        passWord = Console.ReadLine();
                        if (passWord == userPassWords[i])
                        {
                            // let the user know they logged in and gives login tries the value of 4 to get out of the loop
                            Console.WriteLine("you are logged in");
                            loginTries = 4;
                        }
                    }

                }
                // if the user is typed in the wrong username or password they are asked to type it in again also counting how many times they tried
                // to login
                if (loginTries < 3)
                {
                    Console.WriteLine("Wrong username or password try again");
                    Console.WriteLine("please type in your username and password and try again");
                    loginTries++;
                    userName = Console.ReadLine();
                }
                // if the user tried 3 times they are locked out of the program
                if (loginTries == 3)
                {
                    Console.WriteLine("You are locked out");
                    Console.WriteLine("you tried to login to many times");
                }
            }
            // if the user logged in they are greeted welcoming them
            if (loginTries == 4)
            {
                Console.WriteLine("Welcome " + userName); 
            }

        }
    }
}
