void CalculatorApp()
{
    try
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /):");
        var operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
        }

        Console.WriteLine($"The result is: {result}");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}. please enter a vaild operation");
        //output message to screen


        throw;
    }
}

    
CalculatorApp();