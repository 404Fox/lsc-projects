// StockCommission.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>//Provides setw and other stream controls

using namespace std; //Placing this here allows its scope to extend to all the later defined functions.

void StockOutput(int StockQuantity, float StockValue, float CommissionRate);//Function declaration. These functions are defined after main().
void AssignComRate();//Function declaration. This is basically like using a header file.

bool elDorito = true;//These variables are allowed to exist outside of main() and all defined functions within this file. Although not necessary for some of these.
bool UseSessionRate = false; //Used as a flag to show whether or not the user specified a session-wide rate.
float SessionComRate;//Persistent value if the user has set it. This is not used for the final function call/calculation directly.
char inputLetter;//Not necessary, but a single input variable for whenever a char is collected from the user.

int main() {
    //Introduction dialogue
    cout << "Welcome to the stock commission calcualtor.\n";
    cout << "This program will allow you to calcualte the overall value and cost of a stock purchase.\n";
    cout << "For example, if you were to purchase 600 stocks at $201.54, with a commission rate of 5%, this program will provide you with this output: \n\n";
    StockOutput(600, 201.54f, 0.05f); //Function call. Using these values it will provide the example output.

    //Ask the user if they want to use a persistent rate for this session
    cout << "\nWould you like to assign a commission rate for this session? (y/n) ";
    cin >> inputLetter;
    if (inputLetter == 'Y' || inputLetter == 'y') { //allows for either capitalization, although this capability isn't consistent with the rest of the program.
        AssignComRate(); //Function call, where the commission rate is assigned to SessionComRate, and UseSessionRate flag is raised.
    } //After assigning the rate, or not, proceed to stock calculation.

    while (elDorito == true) {//This loop allows the user to calculate as many stock commissions as they want
        float CommissionRate; //These temporary variables will hold the values that are fed to StockOutput()
        int StockQuantity; //This does not allow for fractional shares.
        float StockValue;

        //Prompt the user for stock quantity and price
        cout << "\n\n"; //Spacing
        cout << "How many shares will you be buying? ";
        cin >> StockQuantity;//Unsafe usage, since the user can input anything without being prompted about it. This is consistent throughout this program.
        cout << "\n"; //Spacing
        cout << "What is the price per share? $";
        cin >> StockValue;//Although unintentional, the user could input as many decimal places as they want. ie. fractional cents.
        cout << "\n"; //Spacing
        
        if (UseSessionRate == false) {//If the user did not enter a session rate earlier, then we will get one from them now.
            //Prompt the user for a temporary rate.
            cout << "Please enter the commission rate: ";
            cin >> CommissionRate;
            cout << "\n";
        } else {
            CommissionRate = SessionComRate;//Use the value that the user provided earlier in the session.
        }
        if (CommissionRate >= 1) {//Basically, a condition to determine if the user entered an impossible multiplier rate.
            CommissionRate = CommissionRate * 0.01f;//Process the commission rate to ensure that the rate value is multiplicatable
        }//The placement here is important because the user could provide the value in multiple places. Thus, it is processed immediately before usage instead of when the user was prompted.

        StockOutput(StockQuantity, StockValue, CommissionRate);//Function call using the parameters that the user provided.

        //Prompt the user for the next course of action
        cout << "\nWhat would you like to do now?\n";
        cout << "\na - Calculate another stock price.\n";
        cout << "b - Change/set the session commission rate.\n";
        cout << "x - Exit\n\n";
        cout << "Input a letter corresponding to the described selection: ";
        cin >> inputLetter;
        cout << "\n";
        switch (inputLetter) {//The re-usage of inputLetter, it being a higher scope, can cause the program to endlessly loop on certain unhandled exceptions.
        case 'x':
            cout << "Have a nice day!\n\n";
            system("pause");
            elDorito = false;//Immediately exits the loop.
            break;
        case ('b'||'B'):
            AssignComRate();//After this executes, the program will loop.
            break;//Exit the case and switch statement.
        default:
            break;//Do nothing for any other inputs than 'x' or 'b'. This includes case 'a', and will proceed to loop the program.
        }//This is the end of the switch on inputLetter.
    }//This is the end of the loop. 
    return 0;//The only line AFTER the eldorito loop. This ends the program.
}

void StockOutput(int StockQuantity, float StockValue, float CommissionRate) {//Definition for the function as was declared prior to main().
    const string BreakerLine = "---------------------------------------\n";//This definition is used to simply output this spacer line, so that the length is consistent between usages.
    const int NumSpaces = 11;//This value is used for setw, so it can be changed HERE if needed.
    cout.precision(2); //Assigns the number of decimal places to be used
    cout << fixed; //Output the exact number of specified places
    cout << showpoint; //Always output with a decimal place
    cout << BreakerLine << StockQuantity << " shares @ $" << StockValue << "\n" << BreakerLine <<"\n";
    float totalStockPrice = StockQuantity * StockValue;//Because this value is needed twice, it is declared to a variable rather than calculated within the cout statement.
    float commissionAmount = totalStockPrice * CommissionRate; //Because this value is needed twice, it is declared to a variable rather than calculated within the cout statement.
    cout << "Total Stock Price: \t$" << right << setw(NumSpaces) << totalStockPrice << "\n";//Right alignment, to the width allowed 10 spaces
    cout << "Broker Commission: \t$" << right << setw(NumSpaces) << commissionAmount << "\n";//Right alignment, to the width allowed 10 spaces
    cout << "Gross Total: \t\t$"<< right << setw(NumSpaces) << totalStockPrice + commissionAmount << "\n\n" << BreakerLine;//Right alignment, to the width allowed 10 spaces. In this case specifically, the value is calculated inline.
}

void AssignComRate() {//Definition for the function as was declared prior to main().
    UseSessionRate = true;//This flag prevents prompting the user for commission rates in the loop.
    cout << "\nPlease provide the new commission rate for this session: ";//Prompt the user for the rate
    cin >> SessionComRate;//Because this variable was defined in a higher scope it is possible to use it here and there.
}