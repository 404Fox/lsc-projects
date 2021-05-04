#include "Lottery.h"

Lottery::Lottery() {
	system("cls");
	std::cout << "The programs starts with the lucky numbers you play every week in the lottery.\n Enter this week's winning numbers to see if you have a winner!\n";
	lottoNums = {13579, 26791, 33445, 55555, 62483, 77777, 79422, 93121};
	LotteryMenu();
}

void Lottery::LotteryMenu() {
	//Input of the winning numbers
	
	std::cout << "\nEnter the winning numbers one-by-one.\nIf you have entered all numbers, enter the number zero.\n";

	inputCt = 0; //reset if looping
	bool doLoop = true;
	std::string strInput;
	int numInput;
	while (doLoop) {
		numInput = lsApp::Support::promptMinMax(0, 99999, "\n\nEnter your number, or 0 to end number input: ");

		if (numInput == 0) {
			doLoop = false;
		} else {
			inputNums.at(inputCt) = numInput;
			inputCt++;
		}
	}

	//Check the numbers and give the result

	if (CheckArray(inputNums)) {
		std::cout << "We have a winner! Congratulations!";
	}
	else {
		std::cout << "Unforutunately, no hits this round. Good luck next week!\n";
	}


	//Prompt retry

	char inputChar;
	std::cout << "\nTry input again? (y/n)  ";
	std::cin >> inputChar;
	if (inputChar != 'y') {
		LotteryMenu(); //redo of this function
	}
	//end of the function and effectively the scope of this class
}

bool Lottery::CheckArray(std::array<int, ARR_MAX> input) {
	for (int i = 0; i < inputCt; i++) { //inputCt is zero based, and therefore matches the array index
		if (CheckNum(input.at(i))) {
			return true;
		}
	}
	return false;//if you fell through the loop, then there must have been no matches
}

bool Lottery::CheckNum(int input, int index) {
	if (input == lottoNums.at(index)) {
		return true;
	}
	if (index >= lottoNums.size()-1) { //break the loop if we have gone too far
		return false;
	}
	index++;
	CheckNum(input, index); //loop through the array
}
