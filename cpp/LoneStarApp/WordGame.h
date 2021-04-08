#pragma once

#include <iostream>
#include <iomanip> //Provides setw and other stream controls
#include <fstream> //Provides filestream classes. Use for hypothetical WGL class.
#include <filesystem> //Provides functions to work with directories and paths. Use for hypothetical WGL class.
#include <Windows.h> //Provides sleep() which is used to achieve the typewriter effect.
#include <string>

namespace lsApp {
	using namespace std;

	class WordGame {
	private:
		string userName, userAge, userCollege, userPet, userPetName, userJob, userCity;
		string uInput;
		string gameScript[25] = {
			"There once was a person named ", "", //index 1: name
			" who lived in ", "", ".\n", //index 3: city
			"At the age of ", "", //index 6: age
			", ", "", //index 8: name
			" went to college at ",
			"", ".\n", // 10: college
			"", " graduated and went to work as a ", "", ".\n", //12:name, 14:job
			"Then, ", "", " adopted a(n) ", "", " named ", "", ".\n", //17:name, 19:pet, 21:petname
			"They both lived happily ever after!\n\n" };


	public:
		WordGame() {
			cout << "Please enter the following information, then watch the fun unfold!\n";
			getline(cin, userName);
			
			cout << "\nWhat is your name: ";
			getline(cin, userName);		
			gameScript[1] = userName;
			gameScript[8] = userName;
			gameScript[12] = userName;
			gameScript[17] = userName;

			cout << "\nHow old are you, or how old you claim to be: ";
			getline(cin, gameScript[6]); //Fills the array directly. Thus, can only be used once.

			cout << "\nName your favorite city: ";
			getline(cin, gameScript[3]);

			cout << "\nName a college: ";
			getline(cin, gameScript[10]);

			cout << "\nWhat do you want to be when you grow up? : ";
			getline(cin, gameScript[14]);

			cout << "\nYour favorite animal: ";
			getline(cin, gameScript[19]);

			cout << "\nThe name of your favorite fictional character: ";
			getline(cin, gameScript[21]);

			cout << "Ready for the fun? Press [Enter] to continue!\n";
			cin.ignore(999, '\n');
			cout << endl;

		}

		void outputWordGame() {
			int lineCounter = 0;
			int charCounter = 0;
			//loop on the array, working on the individual line
			while (lineCounter < 24) { //Fixed limit based on array length of gamescript
				//Loop on each character
				while (charCounter < gameScript[lineCounter].size()) {
					cout << gameScript[lineCounter][charCounter]; //Print a character
					Sleep(30);
					charCounter++;
				}
				lineCounter++;
				charCounter = 0; //Reset the counter for the loop above, otherwise it will break the read order.
			}
			system("pause");
		}
	};
}