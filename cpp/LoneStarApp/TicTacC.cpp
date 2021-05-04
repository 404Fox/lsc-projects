#include "TicTacC.h"

ticTac::TicTacC::TicTacC()
{
	p1score = 0;
	p2score = 0;
}

void ticTac::TicTacC::playGame()
{
	fillTable(" ");

	bool doLoop = true;
	while (doLoop) {
		renderTable(numTable);
		//I got tired and resorted to a lot of copy/paste
		//Player 1's turn.
		promptPlayer(p1name, p1symbol);
		renderTable(myTable);
		if (checkWinCondition()) {
			std::cout << "\nCongratulations, " << p1name << " you win!";
			p1score++;
			gameOver();
		}
		else if (checkTieCondition()) {
			std::cout << "\nIt's a tie...";
			gameOver();
		}
		//Player 2's turn
		renderTable(numTable);
		promptPlayer(p2name, p2symbol);
		if (checkWinCondition()) {
			std::cout << "\nCongratulations, " << p2name << " you win!";
			p2score++;
			gameOver();
		}
		else if (checkTieCondition()) {
			std::cout << "\nIt's a tie...";
			gameOver();
		}
		system("cls");
	}
}

void ticTac::TicTacC::gameOver()
{
	std::cout << "\n\nWould you like to play again? (y/n)  ";
	std::string userInput;
	std::cin >> userInput;
	if (userInput == "y") {
		playGame();
	}
}

void ticTac::TicTacC::renderTable(std::array<std::string, 10> inTable)
{
	for (int i = 1; i < 10; i += 3 ) { //increment through columns
		std::cout << "| ";
		for (int ir = i; ir < i + 3; ir++) { //increment through the row
			std::cout << inTable.at(ir) << " | ";
		}
		std::cout << "\n";
		std::cout << "-----------------------------";
		std::cout << "\n";
	}
}

void ticTac::TicTacC::setSpot(int index, std::string symbol) {
	if (index < 1 || index > 9) {
		throw "Argument exception: out of range 1-9";
	}
	if (symbol != "X" || symbol != "O") {
		throw "Tried to set a spot without an X or O";
	}

	//myTable.at(index) = symbol; //Unhandled exception at 0x00007FFD3B4F3E49 in LoneStarApp.exe: Microsoft C++ exception: char at memory location 

	if (symbol == "X") {
		myTable.at(index) = "X";
	}
	if (symbol == "O") {
		myTable.at(index) = "O";
	}

}

void ticTac::TicTacC::fillTable(std::string symbol) {
	for (int i = 1; i < 10; i++) {
		myTable.at(i) = symbol;
	}
}

void ticTac::TicTacC::promptPlayer(std::string name, std::string symbol)
{
	bool invalidInput = true;
	bool invalidNum = true;

	std::string userInput;
	int userInputNum;
	do { //Validation: Prevent user from picking an already chosen space.
		do { //Validation: range validation
			std::cout << "\n" << name << ", choose your spot, 1-9:  ";
			std::cin >> userInput;
			userInputNum = std::stoi(userInput);
			if (userInputNum < 10 && userInputNum > 0) { invalidNum = false; }
			else { std::cout << "Number out of range. Please try again."; }
		} while (invalidNum);
		//Check if the spot is taken
		if (checkSpotOpen(userInputNum)) { //if the value of the slot is space, then its OK
			invalidInput = false;
		} else {
			std::cout << "\nThat spot is already chosen. Please choose again.\n";
		}
	} while (invalidInput);
	setSpot(userInputNum, symbol);
}

bool ticTac::TicTacC::checkSpotOpen(int index)
{
	if (myTable.at(index) == " ") {
		return true;
	} else { return false; }
}

bool ticTac::TicTacC::checkWinCondition()
{
	//Check for row matches
	for (int i = 1; i < 10; i += 3) { //Skip 3. This jumps rows.
		std::string a = myTable.at(i);
		std::string b = myTable.at(i + 1);
		std::string c = myTable.at(i + 2);
		if (a == b && b == c && a == c && a != " ") {
			return true;
		}
	}
	//Check for column matches
	for (int i = 1; i <= 3; i++ ) { //Check each column
		std::string a = myTable.at(i);
		std::string b = myTable.at(i + 3);
		std::string c = myTable.at(i + 6);
		if (a == b && b == c && a == c && a != " ") {
			return true;
		}
	}
	//Check for diagonal matches - first-middle-end (1/5/9) this is not as elegant since we can't just x++;y++
	if (myTable.at(1) != " ") {
		if (myTable.at(1) == myTable.at(5) && myTable.at(1) == myTable.at(9)) {
			return true;
		}
	}

	//3rd, middle, 7th
	if (myTable.at(3) != " ") {
		if (myTable.at(3) == myTable.at(5) && myTable.at(1) == myTable.at(7)) {
			return true;
		}
	}

	return false;
}

bool ticTac::TicTacC::checkTieCondition()
{
	for (int i = 1; i < 10; i++) {
		if (myTable.at(i) == " ") { //if there are any open spots
			return false; //then there is not a tie
		}
	} //else, it must be true
	return true;
}
