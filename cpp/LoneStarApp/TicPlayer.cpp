/*#include "TicPlayer.h"

lsApp::TicPlayer::TicPlayer(std::string name, char inSymbol, TicTacToeGame* owner) { //default initializer
	points = 0;
	myName = name;
	gamePtr = owner; //set pointer on this object
}

void lsApp::TicPlayer::prompt(){
	TicTacToeGame::renderTable(&numTable); //Show the player the table of choices.
	bool invalidInput = true;
	bool invalidNum = true;
	char* chosenPosition;
	int chosenIndex = 0;

	char userInput;
	do { //Validation: Prevent user from picking an already chosen space.
		do { //Validation: range validation
			std::cout << "\nChoose your spot, 1-9:  ";
			std::cin >> userInput;
			if (userInput <= 9 || userInput >= 1) { invalidNum = false; }
			else { std::cout << "Number out of range. Please try again."; }
		} while (invalidNum);
		//Check if the spot is taken
		if (*gamePtr->getTablePosition(userInput) == ' ') { //if the value of the slot is space, then its OK
			invalidInput = false;
		}
		else {
			std::cout << "\nThat spot is already chosen. Please choose again.\n";
		}
	} while (invalidInput);
	chosenPosition = gamePtr->getTablePosition(chosenIndex); //get the pointer from the player's pick
	*chosenPosition = symbol; //set the value on teh gameboard
}*/