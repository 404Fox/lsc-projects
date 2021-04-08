#pragma once

#include <fstream>

namespace lsApp {
	using namespace std;
	class Hotel {
	public:
		Hotel() {
			//introduction
			system("cls");
			cout << "  Welcome to the Downtown Hotel System\n";
			cout << lsApp::Support::breakerLine('=') << "\n\nHome away from home and hospitality at its best.\nWe will treat you like never before.\n";
			cout << "This program calculates the occupancy rate of this hotel.\n\n" << lsApp::Support::breakerLine('=') << "\n";
			//get the number of floors
			int floors;
			int* rooms;//Declare pointer to an int for an array
			int* occupiedRooms;
			cout << endl;
			floors = lsApp::Support::promptMinMax(0, 100, "How many floors are in this hotel? ");

			//Initialize parallel arrays
			rooms = new int[floors];
			occupiedRooms = new int[floors];

			//Ask for the number of rooms on each floor
			for (int i = 0; i < floors; i++) {
				//Construct the prompt string.
				string prompt = "\nHow many rooms are on floor ";
				prompt.append(to_string(i+1));
				prompt.append("? "); 
				rooms[i] = lsApp::Support::promptMinMax(10, 100, prompt);

				//Construct the prompt string.
				prompt = "How many rooms are occupied on floor ";
				prompt.append(to_string(i+1));
				prompt.append("? "); 
				occupiedRooms[i] = lsApp::Support::promptMinMax(0, rooms[i], prompt);
			}

			//for readibility, declarations of all result variables
			int totalRooms = 0; //Declare as zero because we use +=
			int occupationCt = 0;
			int availableCt;
			double occupancyRate;
			//sum of rooms
			for (int i = 0; i < floors; i++) {
				totalRooms += rooms[i];
			}
			//sum of occupied rooms
			for (int i = 0; i < floors; i++) {
				occupationCt += occupiedRooms[i];
			}
			//available rooms
			availableCt = totalRooms - occupationCt;
			//occupation rate
			occupancyRate = (static_cast<double>(occupationCt) / totalRooms) * 100;//convert the initial value in division to double

			//Header for results section
			cout << endl << lsApp::Support::breakerLine('=') << "\nReport of rooms at the Hotel...\n" << lsApp::Support::breakerLine('=') << endl;
			//Output results
			cout << "\nTotal rooms at the hotel: " << totalRooms;
			cout << "\nRooms occupied at the hotel: " << occupationCt;
			cout << "\nAvailable rooms at the hotel: " << availableCt;
			cout << fixed << showpoint;
			cout.precision(1);
			cout << "\nOccupation rate: " << occupancyRate << "%\n\n";
			system("pause");
		}
	};
}