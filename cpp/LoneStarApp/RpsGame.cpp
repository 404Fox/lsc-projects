#include "RpsGame.h"
#include <stdlib.h>
#include <time.h>

//A refactoring that would've made this 3x easier would be making string prompts and outputs as functions on each Player.
//Although in another sense, that level of complexity would be unnecessary since most of those functions would be one-liners.

//I chose this format for practice purposes, where the role of player is generic of being human or AI.
//in reflection, Player[] would be ideal instead of separate Player1 and Player2 declarations.
//this game could be expanded to support many players, and only the gameloop must be changed.

//namespace lsApp { //because of an error resulting from declaration ordering in the header, I ended up adding explicit scope for everything...

	std::string rps::RpsGame::getOptionText(OptionSelect option) {
		switch (option) {
		case OptionSelect::paper: return "Paper";
		case OptionSelect::rock: return "Rock";
		case OptionSelect::scissors: return "Scissors";
		}
	}

	rps::RpsGame::RpsGame()
	{
		//Prompt for name
		//Prompt for automatic mode
		roundCount = 0;

		std::string tempName1;
		std::string tempName2;
		bool tempAuto1 = true;
		bool tempAuto2 = true;
		bool doPrompt = true;
		

		while (doPrompt) {

			//prompt for name
			std::cout << "Enter Player 1's Name: ";
			std::cin >> tempName1;
			std::cout << "Enter Player 2's Name: ";
			std::cin >> tempName2;

			std::string userInput;
			//prompt for automatic mode
			std::cout << "\nShould " << tempName1 << " be an AI? (y/n)  ";
			std::cin >> userInput;
			if (userInput != "y") {
				tempAuto1 = false;
			}
			std::cout << "\nShould " << tempName2 << " be an AI? (y/n)  ";
			std::cin >> userInput;
			std::cout << "\n";
			if (userInput != "y") {
				tempAuto2 = false;
			}

			if (tempAuto1) {
				std::cout << tempName1 << " is an AI.\n";
			}
			else {
				std::cout << tempName1 << " is a human.\n";
			}
			if (tempAuto2) {
				std::cout << tempName2 << " is an AI.\n";
			}
			else {
				std::cout << tempName2 << " is a human.\n";
			}
			
			std::cout << "Proceed? (y/n)  ";
			std::cin >> userInput;
			std::cout << "\n";
			if (userInput == "y") {
				doPrompt = false; //exit this loop
			}
		}

		Player1 = Player(tempName1, tempAuto1);
		Player2 = Player(tempName2, tempAuto2);
		Player1.randMod = 99;
		Player2.randMod = 26;
		//GameLoop(); //call externally instead?
	}

	void rps::RpsGame::GameLoop()
	{
		roundCount++;
		system("cls"); //reset screen for clarity
		//output the current round state
		std::cout << "Round " << roundCount << "\n";
		std::cout << Player1.getName() << " has " << Player1.scoreCount << " points.\n";
		std::cout << Player2.getName() << " has " << Player2.scoreCount << " points.\n\n";

		//get selections
		OptionSelect p1Option = Player1.getSelection(); //These variables should be moved to Player...?
		OptionSelect p2Option = Player2.getSelection();

		//Show selections
		std::cout << Player1.getName() << " chose " << getOptionText(p1Option) << "\n";
		std::cout << Player2.getName() << " chose " << getOptionText(p2Option) << "\n\n";

		//output the result
		if (p1Option == p2Option) {
			//tie end
			std::cout << "\nIt's a tie!\n";

		} //all win conditions for p1
		else if (p1Option == rock && p2Option == scissors ||
			p1Option == paper && p2Option == rock ||
			p1Option == scissors && p2Option == paper) {
			std::cout << Player1.getName() << " won this round!\n";
			Player1.scoreCount++;
			std::cout << Player1.getName() << " has " << Player1.scoreCount << " points.\n";
		} //all-else, where p2 has won the round
		else {
			std::cout << Player2.getName() << " won this round!\n";
			Player2.scoreCount++;
			std::cout << Player2.getName() << " has " << Player2.scoreCount << " points.\n\n";
		}
		system("pause");

		//check the end condition
		rps::GameEndData gameEndData = this->checkEndCondition(); //call checkEndCondition on the instance of RpsGame

		if (gameEndData.isGameEnd) { //Should always validate false at the start of the game
			//game over logic
			std::cout << "\n" << gameEndData.winPlayer->getName() << " has won!\n";

			std::string userInput;
			std::cout << "\nWould you like to play again? (y/n) ";
			std::cin >> userInput;
			if (userInput == "y") {
				roundCount = 0;
				Player1.scoreCount = 0;
				Player2.scoreCount = 0;
				GameLoop();
			}
		} else {
			//begin a new round by calling GameLoop()
			GameLoop();
		}
	}

	rps::GameEndData rps::RpsGame::checkEndCondition()
	{
		GameEndData endData = GameEndData();//initialize with an implied constructor
		int p1score = Player1.scoreCount;
		int p2score = Player2.scoreCount;

		if (p1score > p2score+1) { //Win condition is having 2 points ahead of the opponent
			endData.winPlayer = &Player1; //Provide a reference to the player that won
			endData.isGameEnd = true;
		}
		else if (p2score > p1score+1) {
			endData.winPlayer = &Player2;
			endData.isGameEnd = true; //set the end flag
		}
		else {
			endData.isGameEnd = false; //if false, then the pointer is not set and will be null at runtime
		}

		return endData; //always returns the end data object
	}

	rps::Player::Player(std::string name, bool isAuto) //being the only constructor, this class requires a name to create initialize an object 
	{
		isAutomatic = isAuto;
		myName = name; //initialize to the input
		scoreCount = 0; //initialize as zero
	}

	std::string rps::Player::getName() //there is no reason to do this, but I don't feel like changing it
	{
		return myName;
	}

	rps::OptionSelect rps::Player::getSelection()
	{
		if (isAutomatic) {
			return getAutomaticSelection();
		}
		else {
			return getPlayerSelection();
		}

		return OptionSelect::rock;
	}

	rps::OptionSelect rps::Player::getPlayerSelection()
	{
		std::string userInput;
		OptionSelect option;
		bool isValid = false;

		while (!isValid) {
			std::cout << "\nChoose from \n1.  Rock\n2.  Paper\n3.  Scissors\n\n";
			std::cout << myName << ", please choose the number of your choice: ";
			std::cin >> userInput;

			if (userInput == "1") {
				option = rock;
				isValid = true;
			}
			else if (userInput == "2") {
				option = paper;
				isValid = true;
			}
			else if (userInput == "3") {
				option = scissors;
				isValid = true;
			}
			system("cls");//Clear the screen to hide their selection or reset the input
		}
		return option;
	}

	rps::OptionSelect rps::Player::getAutomaticSelection()
	{
		int option;
		srand(randMod * time(0)); //initialize random base on runtime system time
		option = (rand() % 3) + 1; //choose random int between 1-3
		option--;
		return static_cast<OptionSelect>(option); //convert to enum type
	}

	rps::GameEndData::GameEndData() //constructor???
	{
		isGameEnd = false;
	}

	//}