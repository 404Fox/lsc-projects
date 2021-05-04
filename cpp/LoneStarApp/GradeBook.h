#pragma once

#include <iostream>
#include <string>
#include <array>
#include "LsSupport.h"

namespace gb {

	class Student {
	public:
		std::string name = "";
		std::array<double, 4> gradeNums;
		std::array<char, 4> gradeChars;
	};

	class GradeBook
	{
	public:
		GradeBook(); //Initialization
		void gradeBookMenu(); //Gradebook's top menu
		void editNewStudent(); //Add a new student
		void editRemoveStudent(); //Choose a student to remove
		void viewGrades(); //View grades for a student
	private:
		const static int MAX_ARR = 100;
		std::array<Student, MAX_ARR> students;
		std::array<bool, MAX_ARR> validRows;
		//Student* promptStudentSelect(); 
		int promptStudentSelectNum(std::string prompt = "\nPlease select a student from the list:  "); //Prompt the selection of a student
		void printStudentList(); //List all students
		void promptGradesEntry(int index); //Add/overwrite a student's grades
		void printStudentGrades(int index); //Print a student's grades
		void removeStudent(int index); //Remove a student
	};

}