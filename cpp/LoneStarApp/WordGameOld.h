#pragma once

#include <iostream>
#include <iomanip> //Provides setw and other stream controls
#include <fstream> //Provides filestream classes. Use for hypothetical WGL class.
#include <filesystem> //Provides functions to work with directories and paths. Use for hypothetical WGL class.
#include <Windows.h> //Provides sleep() which is used to achieve the typewriter effect.
#include <string>

namespace lsApp { //this is to prevent future conflicts with some of these class names...
	using namespace std;

	static const int MAXWGLEN = 10;

	template <class T>
	class NameTable {
	private:
		string nameArray[MAXWGLEN]; //These are intended to be parallel arrays.
		T objectArray[MAXWGLEN]; //The index of each name corresponds to the same position in the array.
		int topIndex = 0;
		//For simplicity, there is no function to remove items. This is basically a one-way stack.

		int getNameIndex(string Name) {
			bool itemFound = false;
			int indexCounter = 0;
			while (itemFound == false) {
				if (nameArray[indexCounter] == Name) { //Check if the name at this index matches the name in question
					return indexCounter; //provides the index for the name
				}
				else {
					indexCounter++; //move to the next item in the nameArray.
					if (indexCounter > nameArray->size() - 1) { //before looping again, if the counter is out of bounds, then:
						return 0;//fail-safe. replace with throw exception?
					}
				}
			}//End of while loop. This point is never reached as the condition is never true
		}//End of getNameIndex()

	public:
		NameTable() {}
		void addObject(string Name, T Object) {
			nameArray[topIndex] = Name;
			objectArray[topIndex] = Object;
			topIndex++;
		}
		T getObject(string Name) {
			return objectArray[getNameIndex(Name)];
		}
	};

	struct WordGameLibrary { //Structure which holds hardcoded word games as string arrays.
	//As an alternative, this could be written as a class which reads word games from text files.
	//This is not being done here due to a lack of interest for the effort involved, at least not yet.
	public:
		string WordGame[5] = {
			"There once was a person named {NAME} who lived in {NAME}\n",
			"At the age of {NAME}, {NAME} went to college at {NAME}\n",
			"{NAME} graduated and went to work as a {NAME}\n",
			"Then, {NAME} adopted a(n) {NAME} named {NAME}\n",
			"They both lived happily ever after!\n\n" };
		string WordGameB[5] = {
			""
		};

		/* Hypothetical WGL class:
		string[] getGameList() //returns a list of filenames
		string[] getWordGame(string filename) //returns the contents of a word game
		string[] getGamePromptList(string filename) //because a word game contains any number of lines, it can choose which prompts will be necessary.

		thus, it is necessary for a word game to define a list of prompts that will be needed. That way, the program only prompts the user for the necessary prompts for the word game.
		alternative, just give all prompts, even if they are not all used in the game.
		*/
	};

	class WordGame {
	private:
		string myWordGame[5];
		string uInput;
		NameTable<string> userInfo;

	public:
		static void PlayIntro() {
			cout << "This is a fantastic word game!!!\n";

			
		}

		WordGame(string wordGame[]) {
			memcpy(myWordGame, wordGame, sizeof(myWordGame));

			cout << "Please enter the following information, then watch the fun unfold!\n";
			std::getline(cin, uInput);

			cout << "\nWhat is your name: ";
			std::getline(cin, uInput);
			userInfo.addObject("NAME", uInput);

			cout << "\nHow old are you, or how old you claim to be: ";
			std::getline(cin, uInput);
			userInfo.addObject("AGE", uInput);

			cout << "\nName your favorite city: ";
			std::getline(cin, uInput);
			userInfo.addObject("CITY", uInput);

			cout << "\nName a college: ";
			std::getline(cin, uInput);
			userInfo.addObject("COLLEGE", uInput);

			cout << "\nWhat do you want to be when you grow up? : ";
			std::getline(cin, uInput);
			userInfo.addObject("JOB", uInput);

			cout << "\nYour favorite animal: ";
			std::getline(cin, uInput);
			userInfo.addObject("PET", uInput);

			cout << "\nThe name of your favorite fictional character: ";
			std::getline(cin, uInput);
			userInfo.addObject("PETNAME", uInput);

			cout << "Ready for the fun? ";
			system("pause");
		}

		//writes out the contents of the word game array.
		//Does so in a type-writer fashion, each character is printed with a small delay.
		void outputWordGame() {
			int lineCounter = 0;
			int charCounter = 0;
			//loop on the array, working on the individual line
			while (lineCounter < (sizeof(myWordGame)/sizeof(myWordGame[0])-1)) { //-1 because the counter is zero-offset but the size is not.
				//Loop on each character
				while (charCounter < myWordGame[lineCounter].size()) {
					cout << myWordGame[lineCounter][charCounter]; //Print a character
					Sleep(30);
					charCounter++;
				}
				lineCounter++;
				charCounter = 0; //Reset the counter for the loop above, otherwise it will break the read order.
			}
			system("pause");
		}

		//This function will place user inputs into a wordgame.
		//This attempts to use braces {} as an escape that is used to identify a row from the NameTable userInput
		//
		void formatWordGame() { //Returns a pointer to a string array.
			int lineCounter = 0;
			int charCounter = 0; //This will also represent the insert position
			string newWordGame[MAXWGLEN];

			while (lineCounter < (sizeof(myWordGame) / sizeof(myWordGame[0]) - 1)) { //Loop on each line
				string lineBuffer;
				while (charCounter < myWordGame[lineCounter].size()-1) { //Loop on each character
					lineBuffer.push_back(myWordGame[lineCounter][charCounter]);//Add each character to the lineBuffer

					if (myWordGame[lineCounter][charCounter] == '{') { //If we found a {, then process the characters after it in this section
						int identifierCharCounter = 1;
						string identifierBuffer;//Holds the name that we extract from between the braces
						
						//Grab the identifier
						while (myWordGame[lineCounter][charCounter+identifierCharCounter] != '}') {
							identifierBuffer.push_back(myWordGame[lineCounter][charCounter+identifierCharCounter]);
							identifierCharCounter++; //Continue looping through the string to grab the identifier.
							//This value will be added to the charCounter, thus skipping a number of characters in the original string.
							//Thus the necessity of lineBuffer variable, which won't get any of these braced characters once exiting this if() statement.
						}
						lineBuffer.append(userInfo.getObject(identifierBuffer));
						//lineBuffer.insert(charCounter, userInfo.getObject(identifierBuffer)); //Use the identifier to grab the user's information from the table.
						charCounter += identifierCharCounter; //Once exiting if(), the linebuffer loop will skip braced characters in the original string inside wordGame.
					}
					charCounter++;
					
				}
				newWordGame[lineCounter] = lineBuffer;
				lineCounter++;
				charCounter = 0;
			}
			memcpy(myWordGame, newWordGame, sizeof(myWordGame));
			//Loop on each character
				//if the character is an open brace, then loop through the next characters
					//if we find an end brace, then stop adding to the string.
		}
	};
}