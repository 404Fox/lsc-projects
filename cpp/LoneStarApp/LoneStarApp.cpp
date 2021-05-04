#include <iostream>
#include "SalesTaxMonth.h"
#include "WordGame.h"
#include "CalorieCalc.h"
#include "FreezeBoil.h"
#include "Hotel.h"
#include "GuessGame.h"
#include "Hospital.h"
#include "RpsGame.h"
#include "TicTacC.h"
#include "GradeBook.h"
#include "Lottery.h"

//static const string BREAK_LINE = "-------------------------------------------------------------------";//Static value for consistency.

/*
Usage of using namespace std was moved to internal namespaces to prevent errors that came with C++17.
DO NOT declare std within a global scope. lsApp namespace was defined to help prevent issues as well.
*/

int main() {//Beginning of main() where the actual program begins.
    //Introduction text. Only plays once.
    std::cout << "Welcome to the personal economics calculator app." << std::endl << std::endl;
    
    bool ContinueLoop = true;//Exists to enable the loop. There isn't really any good reason for this as far as I know.
    //Main loop begins
    while (ContinueLoop == true) {
        char inputLetter;//inputLetter exists within the scope of an iteration of the loop. This specific variable is not used for anything else and shouldn't be.
        //Prompt the user for a choice. This can be expanded later.
        std::cout << "Please choose an option using the corresponding letter from this list:\n\n";
        std::cout << "a.  Calculate monthly sales tax\n";
        std::cout << "b.  Play a word game\n";
        std::cout << "c.  Calculate calories from fat\n";
        std::cout << "d.  Freezing and Boiling Temperatures\n";
        std::cout << "e.  Hotel Occupancy\n";
        std::cout << "f.  Play a number guessing game\n";
        std::cout << "g.  Calculate Hospital Bill\n";
        std::cout << "h.  Rock Paper Scissors\n";
        std::cout << "i.  Tic Tac Toe\n";
        std::cout << "j.  Grade Book\n";
        std::cout << "k.  Check the Winning Lottery Tickets\n";
        std::cout << "\nx.  Exit\n\n";

        std::cin >> inputLetter; //Takes the input letter used for switch for those listed options.
        std::cout << std::endl;
        //Control feedback section
        switch (inputLetter) {
        case 'a': {
            lsApp::SalesTaxMonth::PlayIntro();//Access and call the function to play the intro. This works because the function is static, and functions without an instantiated object.
            lsApp::SalesTaxMonth MonthA = lsApp::SalesTaxMonth();//Create the object MonthA using the SalesTaxMonth constructor.
            MonthA.OutputResults();//Call the function on MonthA to output it's results.
            break;//End case a
        }
        case 'b': {
            lsApp::WordGame myWordGame = lsApp::WordGame::WordGame();
            myWordGame.outputWordGame();

            //Old word game. too difficult to make work for whatever reason.
            //lsApp::WordGame::PlayIntro();//Static function, plays the WordGame intro.
            //lsApp::WordGameLibrary myWordGameLib; //Creates the object of WGL, which currently only holds a hardcoded script.
            //lsApp::WordGame myWordGame = lsApp::WordGame::WordGame(myWordGameLib.WordGame); //Call the constructor of WordGame, which prompts the user for information.
            //myWordGame.formatWordGame();
            //myWordGame.outputWordGame();
            break; //End case b
        }
        case 'c': {
            lsApp::CalorieCalc(); //This is sort of like calling statically. What happens to the memory after the constructor call?
            break; //Very clean.
        }
        case 'd': {
            lsApp::FreezeBoil frez = lsApp::FreezeBoil();
            break;
        }
        case 'e': {
            lsApp::Hotel();
            break;
        }
        case 'f': {
            //lsApp::GuessGame myGame
            lsApp::GuessGame();
            break;
        }
        case 'g': {
            lsApp::Hospital myHospital = lsApp::Hospital();
            myHospital.mainMenu();
            //myHospital should be destroyed upon exiting the scope of this switch-case, right?
            break;
        }
        case 'h': {
            rps::RpsGame newGame = rps::RpsGame();
            newGame.GameLoop(); //begins the game loop which is recursive.
            break;
        }
        case 'i': {
            ticTac::TicTacC ticGame = ticTac::TicTacC();
            ticGame.playGame();
            break;
        }
        case 'j': {
            gb::GradeBook gradeBook = gb::GradeBook();
            gradeBook.gradeBookMenu();
            break;
        }
        case 'k': {
            Lottery myLotto = Lottery();
            myLotto.LotteryMenu();
            break;
        }
        case 'x': {
            ContinueLoop = false;//Exit the while loop. This will lead to return 0.
        }
        default: { break; }//End bracket of default: which does nothing.
        }//End bracket of switch(inputLetter)
        system("cls");//Send command to clear the console. The position is important because it removes whatever the switch cases have written.
        //This is an infinite loop where the prompt will always be repeated unless you use a proper exit letter
    }//The program ends upon leaving the while(ContinueLoop) loop.
    return 0;//Ends the program.
}