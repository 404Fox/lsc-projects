#pragma once
#include <iostream>

namespace lsApp {
	using namespace std;

	class Hospital {

	private://Should not be externally accessed
		string patientName;

		//Collects prompts
		//Flawed because it assumes that there are only inpatient/outpatient formats. If needed, replace with an enum selection.
		void promptPatient(bool inPatientFlag) {
			int days = 0; //Initialization just in case and because compiler throws warnings about it
			double dailyCharge = 0;
			double medExpense = 0;
			double serviceExpense = 0;
			double min = 0;//ensure that min/max are passed as doubles
			double max = 999999;
			double total;

			//Inpatient additional prompts
			if (inPatientFlag) {
				days = lsApp::Support::promptMinMax(0, 99999, "\nEnter the number of days stayed: "); //use int
				dailyCharge = lsApp::Support::promptMinMax(min, max, "\nEnter the daily charge: "); //use double
			}

			//prompts for both inpatient and outpatient
			medExpense = lsApp::Support::promptMinMax(min, max, "\nEnter the medical expenses: ");
			serviceExpense = lsApp::Support::promptMinMax(min, max, "\nEnter the service charges: ");

			//Call the calcCharges overloaded
			if (inPatientFlag) {
				total = calcCharges(days, dailyCharge, medExpense, serviceExpense);
			} else {
				total = calcCharges(serviceExpense, medExpense);
			}
			cout << setprecision(2) << fixed;//Formatting
			cout << "\nThe total expenses for " << patientName << " are: $" << total << endl << endl;
			system("pause");
			endPrompt();
		}

		//Calculates charges for an inpatient
		double calcCharges(int days, double dailyCharge, double medExpense, double serviceExpense) {
			string input;
			double total = days * dailyCharge;
			total += medExpense;
			return total + serviceExpense;
		}
		//Calculates charges for an outpatient
		double calcCharges(double serviceExpense, double medExpense) {
			string input;
			return serviceExpense + medExpense;
		}

		//Reset the class and enter mainMenu()
		void endPrompt() {
			char input;
			cout << "\nCalculate another patient's bill? (y/n)  ";
			cin >> input;
			if (input == 'y') {

				mainMenu();
			} else {
				//delete this;
			}
			/*
			Heirarchy:

			endPrompt -> promptPatient -> mainMenu
			
			*/
		}
	public:
		Hospital() {
			cout << "Welcome to the El Gatos Hospital Bill Calculator\n";
			cout << "";
		}
		//The entry point for this class
		void mainMenu() {
			char inputSelect;
			cout << "\nEnter the patient's name: ";
			cin >> patientName;

			bool doLoop = true;

			do {
				cout << "\na.  Inpatient bill\nb.  Outpatient bill\nx.  Return to main menu\n";
				cout << "\nChoose an option by entering the letter: ";
				cin >> inputSelect;
				
				switch (inputSelect) {
				case 'a':{
					promptPatient(true);
					doLoop = false;
					break;
				}
				case 'b': {
					promptPatient(false);
					doLoop = false;
					break;
				}
				case 'x': {
					doLoop = false;
					break;
				}
				default: {
					break;
				}
					   //repeat...

				}

			} while (doLoop);
			
			

		}
	};
}