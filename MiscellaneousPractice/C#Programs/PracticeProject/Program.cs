using System;


bool run = true;

Console.WriteLine("Welcome to the Calculate!");
while(run == true) {
	Console.WriteLine("Please type the Option or number of the Option");
	Console.WriteLine("1. Enter Calculator");
	Console.WriteLine("2. Quit Calculator");
	string? option = Console.ReadLine().ToLower();

	//string option function
	
	if (option == "1" || option == "enter calculator" || option == "calculator") {
		TypeOrFile();
	} else if (option == "2" || option == "quit calculator" || option == "quit") {
		run = false;
		break;
	}
}



void TypeOrFile() {
	Console.WriteLine("Please Enter the Option or number of the Option");
	Console.WriteLine("1. Calculate expression from a file");
	Console.WriteLine("2. Calculate expression by typing");
	string? option = Console.ReadLine().ToLower();

	if (option == "1" || option == "Calculate expression from a file" || option == "file") {
		string[] fileExpressions = getFileExpressions();
		//fileNumberExpression = Parse(fileExpressions);
	} else if (option == "2" || option == "Calculate expression by typing" || option == "typing") {
		string expression = getTypedExpression();
		string numberExpression = Parse(expression);
		Console.WriteLine(numberExpression);
		string allNumbersOperators = NumberBuilder(numberExpression);
		Console.WriteLine(allNumbersOperators);
	}
}

string getTypedExpression() {
	Console.WriteLine("Please Enter the Expression");
	string? expression = Console.ReadLine();
	return expression;
}

string[] getFileExpressions() {
	Console.WriteLine("Please Enter the File Name");
	string? fileName = Console.ReadLine();
	string[] fileLines = System.IO.File.ReadAllLines(fileName);
	return fileLines;
}

string Parse(string input) {
	string[] expression = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
	string numberExpression = " ";
	
	Dictionary<string, int> numbersConvert = new Dictionary<string, int>() {
		{"one", 1},
		{"two", 2},
		{"three", 3},
		{"four", 4},
		{"five", 5},
		{"six", 6},
		{"seven", 7},
		{"eight", 8},
		{"nine", 9},
		{"ten", 10},
		{"zero", 0},
		{"eleven", 11},
		{"twelve", 12},
		{"thirteen", 13},
		{"fourteen", 14},
		{"fifteen", 15},
		{"sixteen", 16},
		{"seventeen", 17},
		{"eighteen", 18},
		{"nineteen", 19},
		{"twenty", 20},
		{"thirty", 30},
		{"forty", 40},
		{"fifty", 50},
		{"sixty", 60},
		{"seventy", 70},
		{"eighty", 80},
		{"ninty", 90},
		{"hundred", 100},
		{"thousand", 1000},
		{"million", 1000000},
		{"billion", 1000000000}
	};

	foreach(string word in expression) {
		if(numbersConvert.ContainsKey(word)) {
			numberExpression += numbersConvert[word] + " ";
		} else {
			numberExpression += word + " ";
		}
	}
	return numberExpression;
}

string NumberBuilder(string expression) {
	string[] brokenExpression = expression.Split(' ');
	string? numberedExpression = " ";
	double subtotal = 0;
	Array.ForEach(brokenExpression, Console.WriteLine);
	for(int i = 0; i < brokenExpression.Length - 1; i++) {
		Console.WriteLine(brokenExpression[i]);
	    if (i+1 == brokenExpression.Length && subtotal == 0) {
		    numberedExpression += brokenExpression[i];
		    break;
	    } else if (i+1 == brokenExpression.Length && subtotal != 0 && Int32.TryParse(brokenExpression[i], out int a)) {
		    if (Int32.Parse(brokenExpression[i]) > subtotal) {
			numberedExpression += (subtotal * Int32.Parse(brokenExpression[i]));
			break;
		    } else if (Int32.Parse(brokenExpression[i]) < subtotal) {
			    numberedExpression += (subtotal + Int32.Parse(brokenExpression[i]));
			    break;
		    }
	   } else {
		if (Int32.TryParse(brokenExpression[i], out int j) && Int32.TryParse(brokenExpression[i+1], out int k) && subtotal == 0) {
			if (Int32.Parse(brokenExpression[i]) > Int32.Parse(brokenExpression[i+1])) {
				subtotal += (Int32.Parse(brokenExpression[i]) + Int32.Parse(brokenExpression[i+1]));	
			} else if (Int32.Parse(brokenExpression[i]) < Int32.Parse(brokenExpression[i+1])) {
				subtotal += (Int32.Parse(brokenExpression[i]) * Int32.Parse(brokenExpression[i+1]));
			} else {
				Console.WriteLine("Something broke case: 1");
			}
		} else if (Int32.TryParse(brokenExpression[i], out int l) && Int32.TryParse(brokenExpression[i+1], out int m) && subtotal != 0) {
			if (Int32.Parse(brokenExpression[i]) > Int32.Parse(brokenExpression[i+1])) {
				subtotal += (subtotal + Int32.Parse(brokenExpression[i+1]));
			} else if (Int32.Parse(brokenExpression[i]) < Int32.Parse(brokenExpression[i+1])) {
				subtotal += (subtotal * Int32.Parse(brokenExpression[i+1]));
			} else {
				Console.WriteLine("Something broke case: 2");
			}
		} else if (Int32.TryParse(brokenExpression[i], out int o) && !Int32.TryParse(brokenExpression[i+1], out int n) && subtotal == 0) {
			if (brokenExpression[i+1] == "plus") {
				numberedExpression += brokenExpression[i] + " + ";
				i++;
			} else if (brokenExpression[i+1] == "times") {
				numberedExpression += brokenExpression[i] + " * ";
				i++;
			} else if (brokenExpression[i+1] == "divided" && brokenExpression[i+2] == "by") {
				numberedExpression += brokenExpression[i] + " / ";
				i = i + 2;
			} else if (brokenExpression[i+1] == "minus") {
				numberedExpression += brokenExpression[i] + " - ";
				i++;
			} else if (brokenExpression[i+1] == "dot" || brokenExpression[i+1] == "point") {
				//do stuff for later
			} else if (/*Char.IsNumber(brokenExpression[i+1][0]) || */brokenExpression[i+1][0] == '+' || brokenExpression[i+1][0] == '*' || brokenExpression[i+1][0] == '/' || brokenExpression[i+1][0] == '-' || brokenExpression[i+1][0] == '.') {
				numberedExpression += brokenExpression[i] + brokenExpression[i+1];
				i++;
			} else {
				Console.WriteLine("Something broke case: 3 ***no operator or number detect in segment***");
			}
		} else if (Int32.TryParse(brokenExpression[i], out int r) && !Int32.TryParse(brokenExpression[i+1], out int q) && subtotal != 0) {
			if (brokenExpression[i+1] == "plus") {
                                numberedExpression += subtotal + " + ";
                                i++;
                        } else if (brokenExpression[i+1] == "times") {
                                numberedExpression += subtotal + " * ";
                                i++;
                        } else if (brokenExpression[i+1] == "divided" && brokenExpression[i+2] == "by") {
                                numberedExpression += subtotal + " / ";
                                i = i + 2;
                        } else if (brokenExpression[i+1] == "minus") {
                                numberedExpression += subtotal + " - ";
                                i++;
                        } else if (brokenExpression[i+1] == "dot" || brokenExpression[i+1] == "point") {
                                //do stuff for later
                        } else if (Char.IsNumber(brokenExpression[i+1][0]) || brokenExpression[i+1][0] == '+' || brokenExpression[i+1][0] == '*' || brokenExpression[i+1][0] == '/' || brokenExpression[i+1][0] == '-' || brokenExpression[i+1][0] == '.') {
                                numberedExpression += subtotal + brokenExpression[i+1];
                                i++;
                        } else {
                                Console.WriteLine("Something broke case: 4 ***no operator or number detect in segment***");
                        }
			subtotal = 0;
		}
	    }
			
	}
	return numberedExpression;
}






















