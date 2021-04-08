#include <iostream>
#include <iomanip> //Provides setw and other stream controls

using namespace std; //Placing this here allows its scope to extend to all the later defined functions.

static const string BREAK_LINE = "-------------------------------------------------------------------";//Static value for consistency.

//Class SalesTaxMonth. This is used to define the object which contains all the sales tax information so it can be passed as a whole.
//The purpose of this is to help encapsulate the functionality and variables related to Sales Tax, separating it from the main loop.
//Placed in front of main() so it is defined prior to usage. Move to a separate header file later.
class SalesTaxMonth {//opening definition of SalesTaxMonth.
    float TotalCollectedAmt; //Not specified with an access modifier, these variables are all private.
    float SalesAmt;//These variables are only used within this class and cannot be accessed on an instance of this class.
    float CountyTaxAmt;
    float StateTaxAmt;
    float SalesTaxTotalAmt;
    string Month;
    int Year;
    const int NumSpaceCt = 11; //Value used for setw for consistency, at least within this class.
    const float StateSalesTaxRate = 0.04f;//The rate is a constant and can only be changed here, not a user option. FYI, Texas' rate is 6.25%, Montgomery's rate is 2%. The numbers used are the specified amounts in the instruction PDF. 
    const float CountySalesTaxRate = 0.02f;//Montgomery county's tax rate 
    //These variables are declared with 0.04 instead of 1.04 (1 is added later) so that the values can be added without doubling 1.

public: //Publicly accessible members of class SalesTaxMonth
    SalesTaxMonth() {//It feels dirty to collect information within a constructor, and not through the function parameters, but oh well
        cout << "Please enter the month of sales -> ";
        cin >> Month; cout << endl; //For organization purposes, the endl is on the same line unlike before.
        cout << "Please enter the year of the sales -> ";
        cin >> Year; cout << endl;
        cout << "Please enter the total register sales collected -> ";
        cin >> TotalCollectedAmt;//Fortunately avoids a divide-by-zero exception.
        cout << endl << endl; //Spacers.

        SalesAmt = TotalCollectedAmt / (StateSalesTaxRate + CountySalesTaxRate + 1);//Divide the totalamt by the overall sales tax rate.
        CountyTaxAmt = SalesAmt * (CountySalesTaxRate);//Determine the amount of money for the county's sales tax
        StateTaxAmt = SalesAmt * (StateSalesTaxRate);//Determine the amount of sales taxed by the state
        SalesTaxTotalAmt = StateTaxAmt + CountyTaxAmt;//The total tax amount
    }
    //The PlayIntro will always be used first, but this design means that this dialogue doesn't have to play for every SalesTaxMonth object created.
    static void PlayIntro() { //Because this function is not dependent on variables within this object, static allows it to be used for the introduction which the user has not yet provided any information.
        cout << BREAK_LINE << endl << "The company must file a monthly sales tax report listing the sales\nfrom the month and the amount of sales tax collected." << endl;
        cout << "Please input data when asked to find the monthly sales tax figures." << endl << BREAK_LINE << endl;
    }//End the definition of static function PlayIntro()
    void OutputResults() {//void function - does not resolve to a value where it was called.
        cout << fixed << showpoint; //Forces exact number of places and usage of a decimal
        cout.precision(2); //Assigns the number of decimal places to be used
        cout << "For " << Month << ", " << Year << endl << BREAK_LINE << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt. Additionally in this line, a break line.
        cout << "Total Collected:\t$" << right << setw(NumSpaceCt) << TotalCollectedAmt << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt
        cout << "Sales:\t\t\t$" << right << setw(NumSpaceCt) << SalesAmt << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt
        cout << "County Sales Tax:\t$" << right << setw(NumSpaceCt) << CountyTaxAmt << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt
        cout << "State Sales Tax:\t$" << right << setw(NumSpaceCt) << StateTaxAmt << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt
        cout << "Total Sales Tax:\t$" << right << setw(NumSpaceCt) << SalesTaxTotalAmt << endl << endl;//Right alignment, to the width allowed spaces defined by NumSpaceCt
        system("pause");
    }//End definition of function OutputResults; No return required.
};//End definition of class StateTaxMonth

int main() {//Beginning of main() where the actual program begins.
    //Introduction text. Only plays once.
    cout << "Welcome to the personal economics calculator app." << endl << endl;

    bool ContinueLoop = true;//Exists to enable the loop. There isn't really any good reason for this as far as I know.
    //Main loop begins
    while (ContinueLoop == true) {
        char inputLetter;//inputLetter exists within the scope of an iteration of the loop. This specific variable is not used for anything else and shouldn't be.
        //Prompt the user for a choice. This can be expanded later.
        cout << "Please choose an option using the corresponding letter from this list:\n\n";
        cout << "a.  Calculate monthly sales tax\n";
        cout << "x.  Exit\n";

        cin >> inputLetter; //Takes the input letter used for switch for those listed options.
        cout << endl;

        //Control feedback section
        switch (inputLetter) {
        case 'a': {
            SalesTaxMonth::PlayIntro();//Access and call the function to play the intro. This works because the function is static, and functions without an instantiated object.
            SalesTaxMonth MonthA = SalesTaxMonth();//Create the object MonthA using the SalesTaxMonth constructor.
            MonthA.OutputResults();//Call the function on MonthA to output it's results.
            break;//End case a
        }
        case 'x': {
            ContinueLoop = false;//Exit the while loop. This will lead to return 0.
        }
        default: { break; }//End bracket of default: which does nothing.
        }//End bracket of switch(inputLetter)
        system("cls");//Send command to clear the console. The position is important because it removes whatever case-objects have written.
        //This is an infinite loop where the prompt will always be repeated unless you use a proper exit letter
    }//The program ends upon leaving the while(ContinueLoop) loop.
    return 0;//Ends the program.
}