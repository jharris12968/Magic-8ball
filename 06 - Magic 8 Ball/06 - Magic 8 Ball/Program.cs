namespace _06___Magic_8_Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Step 1 - Seekers Name
            Console.WriteLine("Seeker, What is your name?");
            string name = Console.ReadLine();

            bool diffQuestion = true;
            while (diffQuestion)
            {

                //Step 2 - Seeker thinks of a question
                Console.WriteLine("What is your question, peasant?");
                string question = Console.ReadLine();

                //Step 3 - Generate a lucky number
                Random random = new Random();
                int randomNumber = random.Next(1, 20);
                Console.WriteLine("Here is your lucky number:" + randomNumber);

                //Step 3a - Display seekers name and question
                Console.WriteLine(name + ", are you sure you wish to ask this question? " + question);
                string answer = Console.ReadLine().ToLower();
                //**ADDITIONAL**
                //If user answers yes, console will output the answer corresponding to the lucky number, then terminate.
                if (answer == "yes")
                {
                    diffQuestion = false;
                }
                //If user answers no, console will loop and have the user ask a different question.
                else if (answer == "no")
                {
                    continue;
                }
                    string response;
                    switch (randomNumber)
                    {
                        case 1:
                            response = "It is certain.";
                            break;
                        case 2:
                            response = "It is decidedly so.";
                            break;
                        case 3:
                            response = "Without a doubt.";
                            break;
                        case 4:
                            response = "Yes - definitely.";
                            break;
                        case 5:
                            response = "You may rely on it.";
                            break;
                        case 6:
                            response = "As I see it, yes.";
                            break;
                        case 7:
                            response = "Most likely.";
                            break;
                        case 8:
                            response = "Outlook good.";
                            break;
                        case 9:
                            response = "Yes.";
                            break;
                        case 10:
                            response = "Signs point to yes.";
                            break;
                        case 11:
                            response = "Reply hazy, try again.";
                            break;
                        case 12:
                            response = "Ask again later.";
                            break;
                        case 13:
                            response = "Better not tell you now.";
                            break;
                        case 14:
                            response = "Cannot predict now.";
                            break;
                        case 15:
                            response = "Concentrate and ask again.";
                            break;
                        case 16:
                            response = "Don't count on it.";
                            break;
                        case 17:
                            response = "My reply is no.";
                            break;
                        case 18:
                            response = "My sources say no.";
                            break;
                        case 19:
                            response = "Outlook not so good.";
                            break;
                        case 20:
                            response = "Very doubtful.";
                            break;
                        default:
                            response = "Invalid response";
                            break;
                    }
                    Console.WriteLine(response);
            }
        }
    }
}
