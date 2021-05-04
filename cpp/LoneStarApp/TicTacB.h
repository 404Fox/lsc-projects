#pragma once

#include <iostream>
#include <string>
#include <array>
#include <tuple>

class TicTacB
{ //C++11 TicTacToe
public:
	TicTacB(); //setup
	void playGame(); //begin the games

private:
	std::array<char, 10> myTable; //start from 1
	std::array<char, 10> numTable = {' ', };
	std::string p1name = "Player 1";
	std::string p2name = "Player 2";
	char p1symbol = 'X';
	char p2symbol = 'O';
	int p1score;
	int p2score;
	
	void gameOver();
	void renderTable(std::array<char, 10> inTable);
	void setSpot(int index, char symbol);
	void fillTable(char symbol);
	void promptPlayer(std::string name, char symbol);

	bool checkSpotOpen(int index);
	bool checkWinCondition();
	bool checkTieCondition();

};

