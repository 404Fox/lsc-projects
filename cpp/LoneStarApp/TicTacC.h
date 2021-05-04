#pragma once

#include <iostream>
#include <string>
#include <array>
#include <tuple>
namespace ticTac {
	class TicTacC
	{ //C++11 TicTacToe
	public:
		TicTacC(); //setup
		void playGame(); //begin the games

	private:
		std::array<std::string, 10> myTable; //start from 1
		std::array<std::string, 10> numTable = { " ", "1","2","3","4","5","6","7","8","9" };
		std::string p1name = "Player 1";
		std::string p2name = "Player 2";
		std::string p1symbol = "X";
		std::string p2symbol = "O";
		int p1score;
		int p2score;

		void gameOver();
		void renderTable(std::array<std::string, 10> inTable);
		void setSpot(int index, std::string symbol);
		void fillTable(std::string symbol);
		void promptPlayer(std::string name, std::string symbol);

		bool checkSpotOpen(int index);
		bool checkWinCondition();
		bool checkTieCondition();

	};

}