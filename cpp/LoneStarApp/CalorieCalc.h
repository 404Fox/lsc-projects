#pragma once

#include <iostream>
#include <iomanip>
#include <string>

namespace lsApp {
	using namespace std;
	class CalorieCalc {

	private:
		double gFat;
		double calTotal;
		double fatRate;
		bool wholeLoop = true;
		bool isValidDouble(string input) { //This honestly feels dirty but probably works with high confidence. This relies on stod to perform validation.
			try {
				double d = stod(input);
				return true;
			}
			catch (exception& e) {
				e.~exception();//destroy e. this is just to prevent warning about unreferenced objects
				return false;
			}
		}

	public:
		CalorieCalc() {
			//cout params for this session.
			cout << fixed << showpoint;
			cout.precision(2);
			system("cls"); //run command to clear screen

			//Introduction
			cout << "CALORIES VS CALORIES FROM FAT\n";
			cout << "Calories provide a measure of how much energy you get from a single serving of this food.\n";
			cout << "Many Americans consume more calories than they need without meeting recommended intakes for a number of nutrients.\nOne gram of fat has 9 calories.\nFoods with less than 30% calories are considered low in fat.\nThis program will calculate the percentage of fat in a food based on your input of total claories and fat in grams.\n" << endl;
			system("pause");

			//Loop calculation
			while (wholeLoop) {
				system("cls");
				//Input validation loop for grams of fat.
				do {
					cout << "Please enter grams of fat: ";
					string inputFat;
					cin >> inputFat;
					if (!isValidDouble(inputFat)) {
						cout << "The input " << inputFat << " was not valid. Please try again.\n";
					}
					else {
						gFat = stod(inputFat);
						break;
					}
				} while (true);
				//Input validation for calories.
				do {
					cout << "Please enter total calories: ";
					string inputCal;
					cin >> inputCal;
					if (!isValidDouble(inputCal)) {
						cout << "The input " << inputCal << " was not valid. Please try again.\n";
					}
					else {
						calTotal = stod(inputCal);
						break;
					}
				} while (true);

				//Calculated results
				fatRate = ((gFat * 9) / calTotal) * 100;

				cout << "With " << gFat << " grams of fat and " << calTotal << " total calories,\n";
				cout << fatRate << "% of calories come from fat.\n";
				if (fatRate <= 30.0) {
					cout << "\nThis food is low in fat.\n";
				}
				//Loop program prompt
				cout << "Again? (y/n)\t";
				char inputChar;
				cin >> inputChar;
				if (inputChar == 'n' || inputChar == 'N') {
					wholeLoop = false;
				}
			} //End of wholeLoop
		}//End of constructor
		//This could be written as a static function, thus not requiring defining an object.
	};
}