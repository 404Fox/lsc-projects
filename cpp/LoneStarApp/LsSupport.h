#pragma once
#include <string>

namespace lsApp{
	using namespace std;

	//Support class provides static pure functions
	class Support {
	public:
		//Determine if the string passes through std::stod()
		static bool isValidDouble(string input) { //This honestly feels dirty but probably works with high confidence. This relies on stod to perform validation.
			try {
				double d = stod(input);
				return true;
			}
			catch (exception& e) {
				e.~exception();//destroy e. this is just to prevent warning about unreferenced objects
				return false;
			}
		}
		static bool isValidInt(string input) {
			try {
				int i = stoi(input);
				return true;
			}
			catch (exception& e) {
				e.~exception();//destroy e. this is just to prevent warning about unreferenced objects
				return false;
			}
		}
		//Applies minimum and maximum ranges to a value.
		static double minMax(double min, double max, double val) {
			if (val > min && val < max) {
				return val;
			} else if (val < min) {
				return min;
			} else { return max; }
		}
		//Returns if the input was within the provided min and max. < and >.
		static bool isMinMax(int min, int max, int input) {
			if (input < min || input > max) { //if the value is higher or lower than max/min
				return false;
			} else { return true; }//else, it is within range
		}
		static bool isMinMax(double min, double max, double input) {
			if (input <= min || input >= max) { //if the value is higher or lower than max/min
				return false;
			} else { return true; }//else, it is within range
		}

		static string breakerLine(char c) {
			//Get the width of the active console window
			//repeat append(c) to the output string, fixed to the width of the window
			string line = "";
			int charCount = 30;
			for (int i = 0; i < charCount; i++) {
				line.push_back(c);
			}
			return line;
		}
		//Validation loop based on a min and max values.
		//reqText: The prompt
		static int promptMinMax(int min, int max, string promptText) {
			//declare variables outside the loop where needed.
			string input;

			do {
				cout << promptText;
				cin >> input;

				if (isValidInt(input)) {
					int value = stoi(input);
					if (isMinMax(min, max, value)) {
						return value;
					} else {
						if (value < min) {
							cout << "\nInput was below the minimum: " << min;
						} else {
							cout << "\nInput was above the maximum: " << max;
						}
						cout << "\nPlease try again.\n";
					}
				} else {
					cout << "\nInput was not a valid integer. Please try again.\n";
				}

			} while (true);
		}
		//Same as above, and overload with double parameters and return type
		static double promptMinMax(double min, double max, string prompt) {
			string input;

			do {
				cout << prompt;
				cin >> input;

				if (isValidInt(input)) {
					double value = stod(input);
					if (minMax(min, max, value)) {
						return value;
					}
					else {
						if (value < min) {
							cout << "\nInput was below the minimum: " << min;
						}
						else {
							cout << "\nInput was above the maximum: " << max;
						}
						cout << "\nPlease try again.\n";
					}
				}
				else {
					cout << "\nInput was not a valid double. Please try again.\n";
				}


			} while (true);


		}

	};



	template <class T>
	class NameTable {
	private:
		string nameArray[999]; //These are intended to be parallel arrays.
		T objectArray[999]; //The index of each name corresponds to the same position in the array.
		int topIndex = 0;
		//For simplicity, there is no function to remove items. This is basically a one-way stack.

		int getNameIndex(string Name) {
			bool itemFound = false;
			int indexCounter = 0;
			while (itemFound == false) {
				if (nameArray[indexCounter] == Name) { //Check if the name at this index matches the name in question
					return indexCounter; //provides the index for the name
				}
				else {
					indexCounter++; //move to the next item in the nameArray.
					if (indexCounter > nameArray->size() - 1) { //before looping again, if the counter is out of bounds, then:
						return 0;//fail-safe. replace with throw exception?
					}
				}
			}//End of while loop. This point is never reached as the condition is never true
		}//End of getNameIndex()
	public:
		NameTable() {}
		void addObject(string Name, T Object) {
			nameArray[topIndex] = Name;
			objectArray[topIndex] = Object;
			topIndex++;
		}
		T getObject(string Name) {
			return objectArray[getNameIndex(Name)];
		}
	};//End of NameTable definition.
}