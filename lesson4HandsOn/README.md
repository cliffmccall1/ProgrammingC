# Lesson 4 Practice Hands-On

## Directions

For your Lesson 4 Practice Hands-On, you will be practicing your new skills learned in this lesson. This Hands-On will not be graded, but we encourage you to complete it. The best way to become a great programmer is to practice! This Hands-On is broken down into three parts, so be sure to complete all requirements. Once you have submitted your project, you will be able to access the solution on the next page. Follow the below steps for setup.

## Setup

Open up your command prompt/terminal.
dotnet new console -o lesson4HandsOn
Once the process is complete, navigate into the lesson4HandsOn directory:
cd lesson4HandsOn
Lastly, run the following to open your new project in VS Code:
code .
For this Hands-On, you will be working within the Program.cs file. Good luck!

## Part 1

Create a method named DoubleMe() which has one integer parameter, doubles that value, and returns the newly doubled value.
Give the method the appropriate data type to match what is being returned.
Using the Main method, print out the doubled value with a label.
Your output will look similar to the following:
_Doubled Number: 8_

## Part 2

Create a new method named QuadrupleMe() that has one integer parameter, quadruples that value, and returns the new value.
Give the method the appropriate data type to match what is being returned.
When quadrupling the number, use the DoubleMe() method to double the value twice.
Hint! You will use the DoubleMe() method twice.

Using the Main method, print out the quadrupled value with a label.
Your output will look similar to the following:
_Quadrupled Number: 20_

## Part 3

Write a new method called DoubleNumberMultipleTimes() which takes in two parameters:
The first parameter is an integer that will be doubled
The second parameter is an integer defining how many times you want to double that value.
For example, if the values 2 and 4 were passed in, the 2 would be doubled once to produce 4, twice to produce 8, and a third time to produce 32.
_Hint! You will need to use a loop._

Give the method the appropriate data type to match what is being returned.
Using the Main method, print out the result of the value after being doubled the specified number of times. Your output will look similar to the following:
_Number Doubled Many Times: 32_

### Final Output

When you are finished will all three parts, your output should look similar to the following:

_Doubled Number: 8_
_Quadrupled Number: 20_
_Number Doubled Many Times: 32_
