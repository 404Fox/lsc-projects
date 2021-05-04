#include "GradeBook.h"

class Student;

gb::GradeBook::GradeBook(){
    validRows.fill(false);

} // no need to do anything?

void gb::GradeBook::gradeBookMenu()
{
    using namespace std;
    bool doLoop = true;
    char input;
    do {
        system("cls");
        cout << "1.  View student list\n";
        cout << "2.  View a student's grades\n";
        cout << "3.  Change a student's grades\n";
        cout << "4.  Add a new student\n";
        cout << "5.  Remove students\n";
        cout << "\nx.  Return to main menu\n\n";

        cin >> input;

        switch (input) {
        case '1': {
            if (!validRows.at(0)) {
                cout << "\nThere are no students!\n";
                system("pause");
                break;
            }
            printStudentList();
            system("pause");
            break;
        }
        case '2': {
            if (!validRows.at(0)) {
                cout << "\nThere are no students!\n";
                system("pause");
                break;
            }
            viewGrades();
            break;
        }
        case '3': {
            if (!validRows.at(0)) {
                cout << "\nThere are no students!\n";
                system("pause");
                break;
            }
            int select = promptStudentSelectNum();
            promptGradesEntry(select);
            break;
        }
        case '4': {
            editNewStudent();
            break;
        }
        case '5': {
            if (!validRows.at(0)) {
                cout << "\nThere are no students!\n";
                system("pause");
                break;
            }
            editRemoveStudent();
            break;
        }
        case 'x': {
            doLoop = false;
            break;
        }
        default: {
            break;
        }
        }
    } while (doLoop);
}

void gb::GradeBook::editNewStudent()
{
    std::cout << "Enter the student's name:  ";
    std::string userInput;
    std::cin >> userInput;
    int studentNext = 0;
    for (int i = 0; i < 10; i++) { //find the next open spot to work with
        if (!validRows.at(i)) {
            studentNext = i;
            break;
        }
    }
    students.at(studentNext).name = userInput;
    promptGradesEntry(studentNext);
}

void gb::GradeBook::editRemoveStudent()
{
    int selection = promptStudentSelectNum();
    removeStudent(selection);
}

void gb::GradeBook::viewGrades()
{
    int select = promptStudentSelectNum();
    printStudentGrades(select);
    system("pause");
}

/*
gb::Student *gb::GradeBook::promptStudentSelect()
{
    printStudentList();
    std::cout << "Please select a student from the list:  ";
    //validate number is valid in list
    std::string userInput;
    int userInputNum;
    do {



    } while (true);
    return &students.at(userInputNum);
}
*/

int gb::GradeBook::promptStudentSelectNum(std::string prompt)
{
    printStudentList();
    std::string userInput;
    int userInputNum;
    do {
        std::cout << prompt;
        std::cin >> userInput;
        userInputNum = std::stoi(userInput); //should wrap with try
        if (validRows.at(userInputNum)) { //validate against known rows
            return userInputNum;
        }
        else {
            std::cout << "Invalid number. Please try again.";
        }
    } while (true);
}

void gb::GradeBook::printStudentList() {
    std::cout << "Student List:\n\n";
    for (int i = 0; i < MAX_ARR; i++) {
        if (validRows.at(i)) { //if the row is valid
            std::cout << i << ". " << students.at(i).name << "\n";
        }
    }
}

void gb::GradeBook::promptGradesEntry(int index)
{
    std::cout << "Enter the student's four grades: ";

    for (int i = 0; i < 4; i++) {
        std::string prompt = "Enter grade:  ";
        double choice = lsApp::Support::promptMinMax(0, 100, prompt);
        students.at(index).gradeNums.at(i) = choice;
        char gChar = 'F';
        if (choice > 60) {
            gChar = 'D';
        } if (choice > 70) {
            gChar = 'C';
        } if (choice > 80) {
            gChar = 'B';
        } if (choice > 90) {
            gChar = 'A';
        }
        students.at(index).gradeChars.at(i) = gChar;
        std::cout << "\n";
    }
    validRows.at(index) = true;
}

void gb::GradeBook::printStudentGrades(int index)
{
    std::cout << students.at(index).name << "'s Grades:\n\n";
    for (int i = 0; i < 4; i++) {
        std::cout << "\t"<< students.at(index).gradeNums.at(i) << " | " << students.at(index).gradeChars.at(i) << "\n";
    }
}

void gb::GradeBook::removeStudent(int index)
{
    for (int i = index; i < MAX_ARR-1; i++) {
        students.at(i) = students.at(i + 1);
        validRows.at(i) = validRows.at(i + 1);
    }
}
