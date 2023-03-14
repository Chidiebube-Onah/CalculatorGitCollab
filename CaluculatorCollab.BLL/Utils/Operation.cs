namespace CalculatorCollab.BLL.Utils
{
    public class Operation
    {
        ///<summary>
        ///Accepts yes or no input from the user to quit the app or continue with operations.
        ///</summary>
        public virtual (bool isYes, string msg) ContinueOrQuit(string answer){
            string userAnswer = answer.Trim().ToUpper();
            if(userAnswer == "YES") return (true, $"{answer}");

            if(userAnswer == "NO") return (false, $"{answer}");

            if(userAnswer != "YES" || userAnswer != "NO") return (false, $"{answer} is not a valid choice.");
            return (false, "Error occured.");
        } 
    }
}