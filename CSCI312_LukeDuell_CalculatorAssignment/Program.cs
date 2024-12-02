using System;

namespace CSCI312_LukeDuell_CalculatorAssignment
{
    class InputErrorChecking
    {
        public int result { get; set; }
        public int output_int { get; set; }

        public InputErrorChecking(int result_priv)
        {
            //takes in input from user
            int input_int_priv;
            string input_string_priv = Console.ReadLine();
            //tries input to see if input is a string
            try
            {
                input_int_priv = int.Parse(input_string_priv);
                output_int = input_int_priv;
            }
            //if input is a string error is caught
            catch (FormatException)
            {
                Console.WriteLine("Input entered is incorrect format");
                result_priv = 1;
            }
            //if there is an unexpected character it is caught here
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpected Error: {exception.Message}");
                result_priv = 1;
            }
            //result is stored in a public int
            result = result_priv;
        }
    }
    class Program
    {
        static void Main()
        {
            int ErrorCheck = 0;
            InputErrorChecking u_input = new InputErrorChecking(ErrorCheck);

            int test = u_input.output_int;

            Console.WriteLine(u_input.result);
        }
    }
}
