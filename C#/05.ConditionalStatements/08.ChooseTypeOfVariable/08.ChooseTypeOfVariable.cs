/* Write a program that, depending on the user's choice inputs int, double or string variable.
 * If the variable is integer or double, increases it with 1.
 * If the variable is string, appends "*" at its end.
 * The program must show the value of that variable as a console output. Use switch statement. */

using System;

class hooseTypeOfVariable
{
    static void Main()
    {
		bool isValid;
		string inString;
		byte variableType;
		
		do
		{
			Console.WriteLine("Please, select type of the variable:");
			Console.WriteLine("1.int");
			Console.WriteLine("2.double");
			Console.WriteLine("3.string");
			Console.Write("Enter 1-3:");
			inString = Console.ReadLine();
			isValid = byte.TryParse(inString, out variableType) && (variableType > 0) && (variableType < 4);
			if (!isValid)
			{
				Console.WriteLine();
				Console.WriteLine("Please, enter 1 to 3");
				Console.WriteLine();
			}
		}
		while (!isValid);
		
		switch (variableType)
		{
			case 1:
			{
				int intVariable;
				do
				{
					Console.Write("Please, enter an int variable :");
					inString = Console.ReadLine();
					isValid = int.TryParse(inString, out intVariable) && (intVariable >= int.MinValue) && (intVariable <= int.MaxValue);
					if (!isValid)
					{
						Console.WriteLine();
						Console.WriteLine("Please, enter correct number");
						Console.WriteLine();
					}
				}
				while (!isValid);
				
				intVariable ++;
				
				Console.WriteLine("The new value of the variable is {0}", intVariable);
				break;
			}
			case 2:
			{
                double doubleVariable;
				do
				{
					Console.Write("Please, enter an double variable :");
					inString = Console.ReadLine();
					isValid = double.TryParse(inString, out doubleVariable) && (doubleVariable >= double.MinValue) && (doubleVariable <= double.MaxValue);
					if (!isValid)
					{
						Console.WriteLine();
						Console.WriteLine("Please, enter correct number");
						Console.WriteLine();
					}
				}
				while (!isValid);
				
				doubleVariable = doubleVariable + 1;
				
				Console.WriteLine("The new value of the variable is {0}", doubleVariable);
				break;
			}
			case 3:
			{
				Console.Write("Please, enter an string variable :");
				string stringVariable = Console.ReadLine();
				
				stringVariable = stringVariable + "*";
				
				Console.WriteLine("The new string is: {0}", stringVariable);
				break;	
			}
		}
	}
}

