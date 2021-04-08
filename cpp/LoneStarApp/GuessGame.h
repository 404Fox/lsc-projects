#pragma once

#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <string>

namespace lsApp {
	using namespace std;

	class GuessGame {
		
	public:
		GuessGame() {
			//Introduction.
			system("cls");
			cout << "This program generates a random number between 1 and 100.\nTry to guess the number!\n";
			promptGuess();
			//promptguess can loop indefinitely by passing control to promptReset which passes to promptGuess
			//This probably isn't good for memory usage since the earlier promptGuess() and promptReset() still exist within memory allocation scope.
			//Thus it is possible to play this game so much that it consumes all memory.
		}
	private:
		void promptGuess() {
			int guessTarget;
			srand(time(0)); //Fills a (static?) seed of random based on current system time.
			guessTarget = rand() % 100 + 1; //Provides random value using the (static?) seed.

			int guess;
			string input;
			bool inputInvalid;
			int guessCount = 0;

			//Input guesses until successful
			do {
				inputInvalid = true; //make the input invalid
				cout << "\nGuess a number: ";

				//Input validation loop
				while (inputInvalid) {
					cin >> input;
					try {
						guess = stoi(input); //Try converting the string to an integer
					} catch (exception e) {
						cout << "\nThe input was invalid. Please try again:  ";
						cout << endl;
						guess = NULL; //Prevent breaking the loop just in case
					}
					if (guess != NULL) { inputInvalid = false; } //If the guess is not NULL, or out of bounds, then break the loop.
				}
				guessCount++;

				//Determine the guess response
				if (guess < guessTarget && !inputInvalid) { //Guessed lower than
					cout << "\nYour guess was too low. Try again!\n\n";
				}
				else if (guess > guessTarget && !inputInvalid) { //Guessed greater than
					cout << "\nYour guess was too high. Try again!\n\n";
				} else if (!inputInvalid) {//all-else case that input is equal to guessTarget
					cout << "\nYou did it! Congratulations!\n\n";
				}

			} while (guess != guessTarget);
			//Beyond this point is having made the successful guess.

			cout << "It took you " << guessCount << " tries.\n";
			promptReset();
		}

		void promptReset() {
			cout << "\nWould you like to play again? (enter 'y' to play again or 'n' to quit.):  ";
			string input;
			cin >> input;
			if (input == "y") {
				system("cls");
				promptGuess();
			}
		}
	};

}