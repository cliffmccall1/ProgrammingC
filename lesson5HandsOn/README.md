# Lesson 5 Practice Hands-On

## Directions

For your Lesson 5 Practice Hands-On, you will be practicing your new skills learned in this lesson. This Hands-On will not be graded, but we encourage you to complete it. The best way to become a great programmer is to practice! This Hands-On is broken down into three parts, so be sure to complete all requirements. Once you have submitted your project, you will be able to access the solution on the next page. Follow the below steps for setup.

## Setup

Open up your command prompt/terminal.
Run the following to navigate to your Desktop
_cd desktop_
Next, the following command is the CLI command to create a new project:
_dotnet new console -o lesson5HandsOn_
Once the process is complete, navigate into the lesson5HandsOn directory:
_cd lesson5HandsOn_
Lastly, run the following to open your new project in VS Code:
_code ._
For this Hands-On, you will be working within the Program.cs file. Good luck!

## Part 1

Create a class named **Person** which has first name, last name, and age variables.
Use camel case for the variable names.
Create properties to allow the first name, last name, and age to be accessed and modified.
Instantiate 2 objects using the **Person** class.
Give the new objects values for each of the variables by using dot notation.
Print each of the person's values to look similar to the following:
_Henry Boswald is 33 years old._
_Lola Boswald is 31 years old._

## Part 2

Create a default constructor.
Add an overloaded constructor to handle the following case input:
First name, last name, and age
Instantiate 2 new objects using the Person class.
Define the values of the first name, last name, and age when you instantiate.
Print each of the new object's values to look similar to the following:
_Emilia Hill is 42 years old._
_Lucius Hill is 45 years old._

## Part 3

Whenever a new object is created, we are not checking if the age is valid. What happens if someone enters -5 as an age? That wouldn't be valid. A person's age should be a positive value. Update the necessary constructor and set property to check if the age is a negative value: if it is negative, set the age to 0 and print _"Attempted to set age to an invalid value. Set age to 0 instead."_

**Final Output**
When you are complete, your final output should look similar to the following:

_Henry Boswald is 33 years old._
_Lola Boswald is 31 years old._
_Emilia Hill is 42 years old._
_Lucius Hill is 45 years old._

And if any of the persons' age is below 0, you should get an output like the following:

_Henry Boswald is 33 years old._
_Lola Boswald is 31 years old._
_Attempted to set age to an invalid value. Set age to 0 instead._
_Emilia Hill is 0 years old._
_Lucius Hill is 45 years old._
