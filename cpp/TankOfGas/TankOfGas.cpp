// TankOfGas.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream> //this pre-processor directive allows the program code below to use public definitions from iostream.

int main() //this program is defined within the scope of this function call main().
{//this is an open brace for the scope of main().
    using namespace std; //indicates that we are working within the namespace std. this means that any function/class within std is available without needing namespace resolution on a per-use basis.
    cout << "This program will calculate some numbers regarding the usage of your car. \nSpecifically, the theoretical range based on theoretical mileage numbers.\nYou'll need to provide the fuel capacity of your car, and mile-per-gallon numbers for city and highway driving.\n";//Provide information to the user...
    //this line is intentionally left empty. Below is the code which allows the user to exit the program if they want.
    cout << "\nDo you want to proceed? y / n\t"; //Prompt the user for an input that can exit the program later in the code.
    char inputChar; //declaration of a variable which will store a char.
    cin >> inputChar; //Input to store a char to the variable inputChar. This isn't case safe for the user providing unexpected inputs such as numbers.
    /*
        This if statement will exit the program if the user provided the input n or N to inputChar.
        Otherwise, the program continues. 
    */
    if (inputChar == 'n' || inputChar == 'N') { //this is an if statement. the conditions are if the inputChar holds a value matching either of these char literals
        return 0; //exit the program. this refers to the call for main() which returns a number representing the 
    }//this open-ended usage allows for any characters other than n or N to proceed the program. this might break if a string is provided?
    //this line is intentionally left empty. Below is the code for taking in inputs and storing their variables.
    cout << "\nEnter your car's fuel capacity in gallons: \t"; //request the user to input a number.
    float fuelCap; //declaration of a variable which will store a float.
    cin >> fuelCap;  //input statement which will store and convert input from the cli. this will 'pause' the cli until the user presses enter. this isn't a safe usage since the user could provide unexpected inputs with no code that handles those cases.
    cout << "\nEnter your car's MPG rating for city driving: \t"; //request the user to input a number.
    float cityMPG; //declaration of a variable which will store a float.
    cin >> cityMPG; //input statement which will store and convert input from the cli. this will 'pause' the cli until the user presses enter. this isn't a safe usage since the user could provide unexpected inputs with no code that handles those cases.
    cout << "\nEnter your car's MPG rating for highway driving: \t"; //request the user to input a number.
    float highwayMPG; //declaration of a variable which will store a float.
    cin >> highwayMPG; //input statement which will store and convert input from the cli. this will 'pause' the cli until the user presses enter. this isn't a safe usage since the user could provide unexpected inputs with no code that handles those cases.
    //this line is intentionally left empty. Below is the code of results.
    cout << "\nWith a full tank, your car can theoretically drive " << cityMPG * fuelCap << " miles in city driving\n"; //beginning of results. the actual results are calculated within this line. it isn't necessary to store the resutls in another variable since it doesn't need to be reused or anything.
    cout << "and " << highwayMPG * fuelCap << " miles in highway driving.\n";//end of results
    system("pause");//pause the cli. if the program was executed via running the program from a GUI, the GUI may close the cli upon reaching the end of the code.
}//this brace ends the scope of main() The program returns 0 even without a return statement.

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
