#pragma once //prevents including this in itself, as it would be resulting from #include "TicPlayer.h"

#include <iostream>
#include <string>
//#include "TicPlayer.h"

//this breaks because Error	C2280	'lsApp::TicPlayer &lsApp::TicPlayer::operator =(const lsApp::TicPlayer &)': attempting to reference a deleted function
//basically, the constructor is a deleted function that cannot pass a reference?
//it was able to compile and run but would always have non-exception memory errors and pointers to unreadable memory

/*
An alternative would be to include all checks and rendering in a single loop on the array.
Thus, reducing the need to create functions for each task, reducing the need to copy/pase the loop on the array[3][3]
This is only doable since there is only a need for a single array[3][3].
The function/OOP-based approach makes it suitable for multiple array[3][3] although not necessary for this program.

Another simplification would be to have the array as a one-dimensional char array to begin with.
Thus preventing the problems with converting 1-9 into a [3][3] and only dealing with that for the array render.

Using an std::array would also be a good idea.

Additionally, this overly complicated mess allows for more than 2 players, since checks are only performed against any matching chars
not just X or O
*/
/*
namespace lsApp {
	class TicTacToeGame; //Forward declaration of tictactoegame

	class TicPlayer {
	public:
		int points;
		std::string myName;
		char symbol;
		TicTacToeGame& gameRef; Error	C2280	'lsApp::TicPlayer &lsApp::TicPlayer::operator =(const lsApp::TicPlayer &)': attempting to reference a deleted function

		TicTacToeGame* gamePtr;

		TicPlayer(std::string name, char inSymbol, lsApp::TicTacToeGame& master);
		TicPlayer();

		void prompt();
	private:
		char numTable[3][3] = { {'1','2','3'}, {'4','5','6'}, {'7','8','9'} };
	};
}
*/


namespace lsApp {
	//class TicPlayer; //Forward declaration of TicPlayer

	class TicTacToeGame {
	public:
		//lsApp::TicPlayer player1;
		//lsApp::TicPlayer player2;
		char myTable[3][3];
		char consumedSlots[10]; //start from 1

		//Setup prompts
		TicTacToeGame();
		
		//The game loop
		void playGame();

		//Displays a 3x3 table provided a reference to it
		static void renderTable(char(inTable)[3][3]);

		//Gets a reference to the position in a 2D 3x3 char array, given a 1-9 index
		char& getTablePosition(int index);

		void setSpot(char input, int index);

	private:
		char numTable[3][3] = { {'1','2','3'}, {'4','5','6'}, {'7','8','9'} }; //should be const, but creates problems
		int player1score;
		int player2score;

		//Prompt the player(s)
		void promptp1(std::string playerName, char symbol);

		const char p1symbol = 'X';
		const char p2symbol = 'O';

		bool checkWinCondition();
		bool checkTieCondition();
		//Reset all table values to ' '
		void fillTable();
		//General game end prompt
		void gameOver();

	};



}