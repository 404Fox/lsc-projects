#include "TicTacToeGame.h"

/*
lsApp::TicPlayer::TicPlayer(std::string name, char inSymbol, TicTacToeGame& owner) { //default initializer
	points = 0;
	myName = name;
	symbol = inSymbol;
	TicTacToeGame& gameRef = owner;
	gamePtr = &gameRef; //set pointer on this object
}

//ni
void lsApp::TicPlayer::prompt() {
	TicTacToeGame::renderTable(numTable); //Show the player the table of choices.
	bool invalidInput = true;
	bool invalidNum = true;
	char* chosenPosition;

	std::string userInput;
	int userInputNum;
	do { //Validation: Prevent user from picking an already chosen space.
		do { //Validation: range validation
			std::cout << "\n" << myName << ", choose your spot, 1-9:  ";
			std::cin >> userInput;
			userInputNum = std::stoi(userInput);
			if (userInputNum < 10 && userInputNum > 0) { invalidNum = false; }
			else { std::cout << "Number out of range. Please try again."; }
		} while (invalidNum);
		//Check if the spot is taken
		if (gameRef.getTablePosition(userInputNum) == ' ') { //if the value of the slot is space, then its OK
			invalidInput = false;
		}
		else {
			std::cout << "\nThat spot is already chosen. Please choose again.\n";
		}
	} while (invalidInput);
	//chosenPosition = &gamePtr->getTablePosition(chosenIndex); //set the value of the pointer to the provided address?
	//chosenPosition = &symbol; //set the value on teh gameboard
	gameRef.setSpot(symbol, userInputNum);
}*/

bool lsApp::TicTacToeGame::checkWinCondition() { //IMPORTANT: Call after each prompted turn. If there is a win, the winner is the one who just placed it.
														//check for row matches
	for (int row = 0; row < 3; row++) { //loop on each row
		char a = myTable[row][0];
		char b = myTable[row][1];
		char c = myTable[row][2];
		if (a == b && b == c && a && a != ' ') {
			return true;
		}
	}
	//check for column matches
	for (int col = 0; col < 3; col++) { //loop on each row
		char a = myTable[0][col];
		char b = myTable[1][col];
		char c = myTable[2][col];
		if (a == b && b == c && a && a != ' ') {
			return true;
		}
	}
	//check for diagonal matches
	//Loop: skip every other element
	bool winFlag = false;
	int col = 1;
	char pChar = myTable[0][0]; //pChar is used for comparisons
	for (int row = 1; row < 3; row++) { //compare diagonally to 0,0 starting from 1,1
		if (pChar == myTable[row][col] && pChar != ' ') { //if any do not match, then there is no win.
			winFlag = true;
		}
		else {
			winFlag = false;
		}
		col++;//increases the column value.
	}
	if (winFlag == true) { 
		return true; } //end for L->R diagonal
										 // Same as above, but from right-to-left
	pChar = myTable[0][2];
	col = 2;
	for (int row = 1; row < 3; row++) { //compare diagonally to 0,0 starting from 1,1
		if (pChar == myTable[row][col] && pChar != ' ') { //if any do not match, then there is no win.
			winFlag = true;
		}
		else {
			winFlag = false;
		}
		col--;//decreases the column value.
	}

	return winFlag;

}
//ni
bool lsApp::TicTacToeGame::checkTieCondition()
{
	for (int row = 0; row < 3; row++) {
		for (int col = 0; col < 3; col++) {
			if (myTable[row][col] == ' ') { //if there are any spaces
				return false; //then it is not a tie
			}
		}
	} //if passed all loops, then it must be a tie (true)
	return true;
}

//Reset all table values to ' '
void lsApp::TicTacToeGame::fillTable() {
	for (int row = 0; row < 3; row++) {
		for (int col = 0; col < 3; col++) {
			myTable[row][col] = ' ';
		}
	}
}

void lsApp::TicTacToeGame::gameOver() {
	bool doLoop = true;
	do {
		std::cout << "\n\nWould you like to play again? (y/n)  ";
		std::string userInput;
		std::cin >> userInput;
		if (userInput == "y") {

		}
		else {

		}
	} while (doLoop);
}

//Setup prompts

lsApp::TicTacToeGame::TicTacToeGame() {
	system("cls");
	std::cout << "Introduction text\n\n";
	system("pause");
	//player1 = TicPlayer("Player 1", 'X', *this); //optionally, create prompts to name the players
	//player2 = TicPlayer("Player 2", 'O', *this); //see the declaration of pointer game in TicPlayer

}

//The game loop

void lsApp::TicTacToeGame::playGame() {
	fillTable();

	bool doLoop = true;
	while (doLoop) {
		renderTable(myTable);
		//I got tired and resorted to a lot of copy/paste
		//Player 1's turn.
		promptp1("Player 1",'X');
		renderTable(myTable);
		if (checkWinCondition()) {
			std::cout << "\nCongratulations " << "Player 1" << ", you win!";
			player1score++;
			gameOver();

		}
		else if (checkTieCondition()) {
			std::cout << "\nIt's a tie...";
			gameOver();
		}
		//Player 2's turn
		renderTable(myTable);
		promptp1("Player 2", 'O');
		if (checkWinCondition()) {
			std::cout << "\nCongratulations " << "Player 2" << ", you win!";
			player2score++;
			gameOver();
		}
		else if (checkTieCondition()) {
			std::cout << "\nIt's a tie...";
			gameOver();
		}
		system("cls");
	}
}

//Displays a 3x3 table provided a pointer to it

void lsApp::TicTacToeGame::renderTable(char(inTable)[3][3]) {
	for (int i = 0; i < 3; i++) {
		std::cout << " | ";
		for (int ib = 0; ib < 3; ib++) {
			std::cout << inTable[i][ib];
			std::cout << " | ";
		}
		std::cout << "\n";
	}
}

//Gets a reference to the position in a 2D 3x3 char array, given a 1-9 index

char& lsApp::TicTacToeGame::getTablePosition(int index) {
	int i = 1;
	for (int row = 0; row < 3; row++) {
		for (int col = 0; col < 3; col++) {
			if (i == index) { //return the char when we have counted up to the desired index
				return myTable[row][col];
			}
			i++; //count up when checking each position
		}
	}
}

void lsApp::TicTacToeGame::setSpot(char input, int index)
{
	char pos = getTablePosition(index);
	//char pos = posPtr;
	pos = input;
}

void lsApp::TicTacToeGame::promptp1(std::string playerName, char symbol)
{
	TicTacToeGame::renderTable(numTable); //Show the player the table of choices.
	bool invalidInput = true;
	bool invalidNum = true;
	char* chosenPosition;

	std::string userInput;
	int userInputNum;
	do { //Validation: Prevent user from picking an already chosen space.
		do { //Validation: range validation
			std::cout << "\n" << playerName << ", choose your spot, 1-9:  ";
			std::cin >> userInput;
			userInputNum = std::stoi(userInput);
			if (userInputNum < 10 && userInputNum > 0) { invalidNum = false; }
			else { std::cout << "Number out of range. Please try again."; }
		} while (invalidNum);
		//Check if the spot is taken
		if (getTablePosition(userInputNum) == ' ') { //if the value of the slot is space, then its OK
			invalidInput = false;
		}
		else {
			std::cout << "\nThat spot is already chosen. Please choose again.\n";
		}
	} while (invalidInput);
	//chosenPosition = &gamePtr->getTablePosition(chosenIndex); //set the value of the pointer to the provided address?
	//chosenPosition = &symbol; //set the value on teh gameboard
	setSpot(symbol, userInputNum);

}
