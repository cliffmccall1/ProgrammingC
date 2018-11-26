# Lesson 7 Practice Hands-On

## Directions

For your Lesson 7 Practice Hands-On, you will be practicing your new skills learned in this lesson. This Hands-On will not be graded, but we encourage you to complete it. The best way to become a great programmer is to practice! This Hands-On is broken down into two parts, so be sure to complete all requirements. Once you have submitted your project, you will be able to access the solution on the next page. Follow the below steps for setup.

## Setup

Open up your command prompt/terminal.
Run the following to navigate to your Desktop
_cd desktop_
Navigate into the ProgrammingC# folder:
_cd ProgrammingC#_
Next, the following command is the CLI command to create a new project:
_dotnet new console -o lesson7HandsOn_
Once the process is complete, navigate into the lesson7HandsOn directory:
_cd lesson7HandsOn_
Lastly, run the following to open your new project in VS Code:
_code ._
For this Hands-On, you will be working within the **Program.cs** file. Good luck!

## Part 1

Create a base class named **Employee** (don't forget the constructor). This class should contain the following string variables:
_name_
_salary_
_hireDate_
Add the following three methods to the **Employee** class — each should be virtual:
_getName()_
_getSalary()_
_hiredDate()_
Each of the above methods should print out the value of the corresponding variable along with a label.
See below for the output.
Create a subclass named Engineer that inherits from Employee and includes a new string variable, schoolAttended. Don't forget the constructor.
Within the Main method, instantiate a new Engineer object and call each of the methods (from # 2).
Your output should look similar to the following:
_Employee Name: Rupert Scott_
_Salary: 42000_
_Hire Date: 11/22/12_

## Part 2

Create a subclass of Engineer named SoftwareEngineer.
Within the new class, create a method that will override the getSalary() method and print "Salary: Sorry, this employee's salary is private.".
Create a new instance of the SoftwareEngineer class and call each of the three methods available.
Your output should now look similar to the following:
_Employee Name: Rupert Scott_
_Salary: 42000_
_Hire Date: 11/22/12_
_---------------------------------------------------_
_Employee Name: Shea Rovington_
_Salary: Sorry, this employee's salary is private._
_Hire Date: 03/27/18_
Hint! A print statement was added to include a line to distinguish between the Engineer and SoftwareEngineer instances.
