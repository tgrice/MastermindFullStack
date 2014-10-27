using System.Linq;

namespace MM.Core
{
    public class Feedback
    {
        public string getFeedback(string guess, string code)
        {
            var response = "";
            var testGuess = guess.ToCharArray();
            var testCode = code.ToCharArray();
            for(var i=0; i<testGuess.Count(); i++)
            {
                if (testGuess[i].Equals(testCode[i]))
                {
                    response += "B";
                    testGuess[i] = 'X';
                    testCode[i] = 'Y';
                }
            }
            for(var i=0; i<testGuess.Count(); i++)
            {
                for(var n=0; n<testCode.Count(); n++)
                {
                    if (testGuess[i].Equals(testCode[n]))
                    {
                        response += "W";
                        testGuess[i] = 'X';
                        testCode[n] = 'Y';
                    } 
                }
            }
            if (guess == code)
            {
                response = "Victory!";
            }
            return response;
        }
    }
}
