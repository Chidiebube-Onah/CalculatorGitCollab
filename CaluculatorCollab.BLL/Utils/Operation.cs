namespace CalculatorCollab.BLL.Utils{
    public class Operation
    {
        public static virtual (bool isYes, string msg) ContinueOrQuit(string answer){
            string userAnswer = answer.Trim().ToUpper();
            if(userAnswer == "YES") return (true, $"{answer}");

            if(userAnswer == "NO") return (false, $"{answer}");

            if(!userAnswer == "YES" || "NO") return (false, $"{answer} is not a valid choice.");
        } 
    }
}