/*#pragma once

#include <iostream>
#include <string>
#include "TicTacToeGame.h"

namespace lsApp {
	class TicTacToeGame; //Forward declaration of tictactoegame

	class TicPlayer {
	public:
		int points;
		std::string myName;
		char symbol;
		lsApp::TicTacToeGame* gamePtr; //this is a dirty workaround to modify game data from the Player object.

		TicPlayer(std::string name = "Player", char inSymbol = 'F', lsApp::TicTacToeGame* master = NULL);

		void prompt();
	private:
		char numTable[3][3] = { {'1','2','3'}, {'4','5','6'}, {'7','8','9'} };
	};
}*/