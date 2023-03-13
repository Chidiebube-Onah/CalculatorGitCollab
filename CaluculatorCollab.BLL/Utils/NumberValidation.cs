namespace CalculatorCollab.BLL.Utils
{
   public static class NumberValidation
{
    ///<summary>
    ///Checks if a number is an even number.
    ///</summary>
    public static bool IsEven(int number){
        if(number % 2 == 0) return true;
        return false;
    }

///<summary>
///Checks if a string is convertible to number (decimal; for high number inputs).
///</summary>
  public static bool IsNumber(string number){
bool isNumber = decimal.TryParse(number, out decimal Convertednumber);

if (isNumber) return true;
return false;
    }

///<summary>
///This method checks if the passed number is zero. with default error msg.
///</summary>
     public static (bool isZero, string msg) DivideByZeroHandler(int number){
        if(number <= 0) return (true, $"{number} is greater zero.");
        return (false, $"{number} is less than or equal to zero.");
     }

///<summary>
/// You can use this method to check if input is empty and access the validation message. Return  a tuple (true: boolean, with a success message) and (false: boolean, error message) when it is not.
///</summary>
    public static (bool isIt, string message) IsBlank(this string stringInput)
    {
        if(string.IsNullOrWhiteSpace(stringInput)) return (true, "The input is empty.");
        return (false, "");
    }

 }
}