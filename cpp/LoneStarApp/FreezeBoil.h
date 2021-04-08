#pragma once
#include <iostream>
#include <iomanip>
#include "LsSupport.h"

namespace lsApp {
	using namespace std;

	class FreezeBoil {
	private:
		double temperature = 0.0;
		//FStream fout;

		//Parallel arrays, the first item matches the element from both arrays
		string element[4] = { "Ethyl Alcohol", "Mercury", "Oxygen", "Water" };
		//[element number][min = 0, max = 1]
		double minMax[4][2] = { {-173, 172} , {-38, 676} , {-362, -306} , {32, 212} };
		//Thus, 0 = Alcohol, 1 = Mercury, 2 = Oxygen, 3 = Water.
		//Enum is not necessary, because in any case, we just need to loop through the index not knowing if it is water or alcohol.

		

		//Output a single line in table formatting.
		void tableLine(int elem) {
			//formatted output
			cout << left << setw(25) << setfill(' ') << element[elem];
			cout << minMax[elem][0] << left << setw(25) << setfill(' ') <<  " degrees";
			cout  << minMax[elem][1] <<   " degrees\n" ;

			//cout << element[elem] << left << setw(40) << setfill(' ') << minMax[elem][0] << " Degrees" <<left << setw(40) << setfill(' ') << minMax[elem][1] << " Degrees\n";
		}
		void summaryLine(int elem) {
			if (temperature < minMax[elem][0]) {//Compare temperature to minimum
				cout << "At " << temperature <<"F, "<< element[elem] << " will be frozen solid!\n" ;
			}
			else if (temperature > minMax[elem][1]) {//Compare temperature to maximum
				cout << "At " << temperature << "F, " << element[elem] << " will boil and turn into gas!\n";
			}
			else {//All cases below min and above max are handled, thus the only remaining possibility is within range.
				cout << "At " << temperature << "F, nothing will happen to the contents of " << element[elem] << "!\n";
			}
		}
		void changeLine(int elem) {
			string changeString;
			if (temperature < minMax[elem][0]) {//Compare temperature to minimum
				changeString = "Freezes!";
			} else if (temperature > minMax[elem][1]) {//Compare temperature to maximum
				changeString = "Boils!";
			} else {//All cases below min and above max are handled, thus the only remaining possibility is within range.
				changeString = "No change!";
			}
			cout << left << setw(20) << setfill(' ')<< element[elem]  << changeString << endl;
		}

	public:
		FreezeBoil() {
			//Introduction text.
			cout << "This program compares the temperature in fahrenheit that the user enters,\ncompares it with the following table, and shows all the substances that will\nfreeze and boil at that temperature.\n";
			cout << endl;

			//Opening of the temperature check loop
			bool bigLoop = true;
			while (bigLoop) {
				//input verification loop
				string input;
				while (!lsApp::Support::isValidDouble(input)) { //loop on input validation function. this function is contained in a support class, a static pure function.
					cout << "\nPlease enter a temperature in Fahrenheit: ";
					cin >> input;
					cout << endl;
				}
				temperature = stod(input);

				//Top of the table
				cout <<endl<<left << setw(25) << setfill(' ')<<  "SUBSTANCE" 
					<< "FREEZING POINT (F)" //<< left << setw(10) << setfill(' ')
					<< "          BOILING POINT (F)\n";
				//cout << "\nSUBSTANCE"  << left << setw(40) << setfill(' ') << "FREEZING POINT (F)" << right << setw(40) << setfill(' ') << "BOILING POINT (F)\n";
				cout << "___________________________________________________________________________\n";
				//Loop through the number of elements, and output all results
				for (int i = 0; i < 4; i++) {
					tableLine(i);//call the line function using the current i index
				}
				cout << endl;

				//The change section
				cout << "At " << temperature << " degrees fahrenheit,\n\n";
				for (int i = 0; i < 4; i++) {//same as above loop
					changeLine(i);
				}
				cout << endl;

				//The summary section
				cout << " SUMMARY:\n";
				for (int i = 0; i < 4; i++) {//same as above loop
					summaryLine(i);
				}
				cout << endl;

				//Prompt for repetition (exit condition for bigLoop)
				cout << "Would you like to test another temperature?\nEnter y for yes or n for no: ";
				cin >> input;
				if (input == "n") {
					bigLoop = false;//This causes the loop to end
				}//All other cases, the loop breaks
			}
		}
	};
}