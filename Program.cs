/*   
 Eliza is a famous 1966 computer program written by Joseph Weizenbaum.  It imitates a psychologist by rephrasing many of a patient's statements as questions and posing them to the patient.

Write a syntactically correct C# method definition called CreateElizaResponse.  The method should take a string that represents the client's statement as a parameter and should return a string that represents an appropriate response.  For example:
    If the client's statement contains the word "my", (I am having trouble with my brother), respond with "Tell me more about your " followed by the noun in the statements (Tell me more about your brother).
    If the client's statement contains the word love or hate, respond with "You have strong feelings about that!"
    If neither of the above responses is appropriate, respond with one of the following "Please go on.", "Tell me more" or "Continue".
Write a syntactically correct C# console application that tests your method.  The app should allow the user to enter a phrase from the keyboard, should determine Eliza's response and display Eliza's response to the console.  While not required, you might choose to allow the user to enter phrases repeatedly.   
  */

/*   
 *   
 /Input
//Take user's input (string) representing the client's statement


//Processing
//Check if the client's statement contains specific keywords or patterns, such as "my", "love", or "hate".
//If the statement contains "my", extract the noun following "my" and generate a response "Tell me more about your [noun]".
//If the statement contains "love" or "hate", generate a response "You have strong feelings about that!".
//If none of the above conditions are met, generate a default response "Please go on.", "Tell me more.", or "Continue".
//Return the appropriate response as a string


//Output
//A string representing Eliza's response to the client's statement
   
 */


/*
using System;

class Program 
{
    static void Main(string[] args)
    {
        Eliza eliza = new Eliza(); // Create an instance of the Eliza class

        // Test phrases
        string[] testPhrases = {
            "I am having trouble with my job",
            "I love chocolate",
            "I enjoy reading books"
        };

        // Test Eliza's response for each test phrase
        foreach (string phrase in testPhrases)
        {
            string elizaResponse = eliza.CreateElizaResponse(phrase); 
            Console.WriteLine("Client's statement: " + phrase); 
            Console.WriteLine("Eliza's response: " + elizaResponse); 
            Console.WriteLine(); 
        }

        // Allow the user to enter custom phrases
        Console.WriteLine("Enter a Phrase:");
        string Phrase = Console.ReadLine();
        while (Phrase.ToLower() != "exit")
        {
            string elizaResponse = eliza.CreateElizaResponse(Phrase);
            Console.WriteLine("Eliza's response: " + elizaResponse);
            Console.WriteLine(); 
            Console.WriteLine("Enter a phrase");
            Phrase = Console.ReadLine();
        }
    }
}




public class Eliza 
{

    public string CreateElizaResponse(string clientStatement) 
        
    {
        if (clientStatement.Contains("my")) 
            // needs to check if the clientStatement contains my. and if it does then it needs to extract the noun following 'my'.
        {
            
            int startIndex = clientStatement.IndexOf("my") + 3;
            // Finding the index of "my" and adding 3 to skip "my "
            int endIndex = clientStatement.IndexOf(" ", startIndex); 
            // it needs to find the index of the space after "my"
            if (endIndex == -1) 
                // If no space is found, endIndex is set to the end of the string
                endIndex = clientStatement.Length;
            string noun = clientStatement.Substring(startIndex, endIndex - startIndex); 
            // the string noun equals the clientStatment at startIndex and endIndex minus the startIndex

            return "Tell me more about your " + noun + "?"; 
            // it will now return the right statement plus the noun and a question mark. 
        }
        else if (clientStatement.Contains("love") || clientStatement.Contains("hate")) 
            // in the case of the statement containing a 'love' or 'hate' 
        {
            return "You have strong feelings about that!"; 
            // return a string of the correct statement in a string. 
        }
        else 
        //in the case of none of those options, you want to return either one of three responses at random. 
        {
            
            Random random = new Random(); 
            // Create a random object in order to select from the randomized three responses. 
            int randomNumber = random.Next(3); 
            // Generate a random number 
            string[] defaultResponses = { "Please go on.", "Tell me more.", "Continue." }; 
            // define a string array defualtResponses that is equal to each response.
            return defaultResponses[randomNumber]; 
            // return the defualtResponses, randomized with randomNumber
        }
    }
}

*/





using System;

class Program
{
    static void Main(string[] args)
    {
        Eliza eliza = new Eliza(); // Create an instance of the Eliza class

        // Test phrases
        string[] testPhrases = {
            "I am having trouble with my job",
            "I love chocolate",
            "I enjoy reading books"
        };

        // Test Eliza's response for each test phrase
        foreach (string phrase in testPhrases)
        {
            string elizaResponse = eliza.CreateElizaResponse(phrase);
            Console.WriteLine("Client's statement: " + phrase);
            Console.WriteLine("Eliza's response: " + elizaResponse);
            Console.WriteLine();
        }

        // Allow the user to enter custom phrases
        Console.WriteLine("Enter a Phrase:");
        string Phrase = Console.ReadLine();
        while (Phrase.ToLower() != "exit")
        {
            string elizaResponse = eliza.CreateElizaResponse(Phrase);
            Console.WriteLine("Eliza's response: " + elizaResponse);
            Console.WriteLine();
            Console.WriteLine("Enter a phrase");
            Phrase = Console.ReadLine();
        }
    }
}

public class Eliza
{
    public string CreateElizaResponse(string clientStatement)
    {
        if (clientStatement.Contains("my"))
        {
            int startIndex = clientStatement.IndexOf("my") + 3;
            if (startIndex >= 0)
            {
                int endIndex = clientStatement.IndexOf(" ", startIndex);
                if (endIndex == -1)
                    endIndex = clientStatement.Length;
                string noun = clientStatement.Substring(startIndex, endIndex - startIndex);
                return "Tell me more about your " + noun + "?";
            }
        }
        else if (clientStatement.Contains("love") || clientStatement.Contains("hate"))
        {
            return "You have strong feelings about that!";
        }
        else
        {
            Random random = new Random();
            int randomNumber = random.Next(3);
            string[] defaultResponses = { "Please go on.", "Tell me more.", "Continue." };
            return defaultResponses[randomNumber];
        }
        return "";
    }
}