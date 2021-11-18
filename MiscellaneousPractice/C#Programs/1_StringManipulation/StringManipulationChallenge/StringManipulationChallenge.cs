using System;
using System.Collections.Generic;


namespace StringManipulationChallenge
{
	public class Program
	{
        	static void Main(string[] args)
        	{
            		string userInputString; //this will hold your users message
            		int elementNum;         //this will hold the element number within the messsage that your user indicates
            		char char1;             //this will hold the char value that your user wants to search for in the message.
            		string fName;           //this will hold the users first name
            		string lName;           //this will hold the users last name
            		string userFullName;    //this will hold the users full name;
            
            		//
            		//
            		//implement the required code here and within the methods below.
            		//
            		//

			Console.WriteLine("Please Enter Your First Name: ");
			fName = Console.ReadLine();
			Console.WriteLine("Please Enter You Last Name: ");
			lName = Console.ReadLine();

			Console.WriteLine("Please Enter your Message: ");
			userInputString = Console.ReadLine();
			Console.WriteLine("Please Enter a Number LESS than the Length of Your Message: ");
			elementNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("For Which Character Should I Search for in Your Original Message? ");
			char1 = Convert.ToChar(Console.ReadLine());

			StringToUpper(userInputString);
			StringToLower(userInputString);

			Console.WriteLine("String SubString: " + StringSubstring(userInputString, elementNum));
			Console.WriteLine("Search Char Index: " + SearchChar(userInputString, char1));
			Console.WriteLine("Concat Names " + (userFullName = ConcatNames(fName, lName)));
        	}

        	// This method has one string parameter. 
        	// It will:
        	// 1) change the string to all upper case, 
        	// 2) print the result to the console and 
        	// 3) return the new string.
        	public static string StringToUpper(string x){
            		//throw new NotImplementedException("StringToUpper method not implemented.");
			string upperString = x.ToUpper();
			Console.WriteLine("UpperCase String: " + upperString);
			return upperString;
        	}

        	// This method has one string parameter. 
        	// It will:
        	// 1) change the string to all lower case, 
        	// 2) print the result to the console and 
        	// 3) return the new string.        
        	public static string StringToLower(string x){
            		//throw new NotImplementedException("StringToUpper method not implemented.");
			string lowerString = x.ToLower();
			Console.WriteLine("LowerCase String: " + lowerString);
			return lowerString;

        	}
        
        	// This method has one string parameter. 
        	// It will:
        	// 1) trim the whitespace from before and after the string, 
        	// 2) print the result to the console and 
        	// 3) return the new string.
        	public static string StringTrim(string x){
            		//throw new NotImplementedException("StringTrim method not implemented.");
			string whspTrim = x.Trim();
			Console.WriteLine("Trim WhiteSpace String: " + whspTrim);
			return whspTrim;

        	}
        
        	// This method has two parameters, one string and one integer. 
        	// It will:
        	// 1) get the substring based on the integer received, 
        	// 2) print the result to the console and 
        	// 3) return the new string.
        	public static string StringSubstring(string x, int elementNum){
            		//throw new NotImplementedException("StringSubstring method not implemented.");
			string substring = x.Substring(elementNum);
			return substring;

        	}

        	// This method has two parameters, one string and one char.
        	// It will:
        	// 1) search the string parameter for the char parameter
        	// 2) return the index of the char.
        	public static int SearchChar(string userInputString, char x){
            		//throw new NotImplementedException("SearchChar method not implemented.");
			int indxAt = userInputString.IndexOf(x);
			return indxAt;
        	}

        	// This method has two string parameters.
        	// It will:
        	// 1) concatenate the two strings with a space between them.
        	// 2) return the new string.
        	public static string ConcatNames(string fName, string lName){
            		//throw new NotImplementedException("ConcatNames method not implemented.");
			string name = String.Concat(fName, ' ', lName);
                        return name;

        	}



	}//end of program
}
