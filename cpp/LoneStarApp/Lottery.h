#pragma once
#include <array>
#include <iostream>
#include "LsSupport.h"

class Lottery
{
public:
	Lottery();
	void LotteryMenu();
private:
	const static int ARR_MAX = 99;
	int inputCt = 0;
	std::array<int, ARR_MAX> inputNums;
	std::array<int, ARR_MAX> lottoNums;
	bool CheckArray(std::array<int, ARR_MAX> input);
	bool CheckNum(int input, int index = 0); //Recursive linear search function. Call with only the input value, or use index to offset the search.
};