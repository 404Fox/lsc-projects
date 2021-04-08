#include <string>
#include <iostream>

namespace rps {

	enum OptionSelect {rock, paper, scissors};
	
	

	class Player {
	public:
		Player(std::string name = "Anonymous", bool isAuto = true); //default constructor with default parameters
		bool isAutomatic; //set if automatically chooses 
		int scoreCount; //controlled by RpsGame
		std::string getName(); //Provides the name of this player
		OptionSelect getSelection(); //May prompt and display some output
		int randMod;
	private:
		std::string myName;
		OptionSelect getPlayerSelection();
		OptionSelect getAutomaticSelection();
	};

	struct GameEndData {
	public:
		GameEndData();
		bool isGameEnd;
		rps::Player* winPlayer;
	};

	class RpsGame {
	public: 
		std::string getOptionText(OptionSelect option);
		RpsGame(); //Prompts for auto parameters and sets names
		void GameLoop();
		
	private:
		int roundCount;
		rps::Player Player1;
		rps::Player Player2;
		GameEndData checkEndCondition();
	};

}