#Lesson 10 Final Project 200 points

## Directions

Welcome to the Final Project for the Programming Foundations in C# course! Great job making it this far! This Final Project will be different from the Hands-On projects you have previously seen in a couple of different ways. For the Final Project, you will be putting together the numerous topics you have learned into one large project. It is designed to mimic real problems which you may face in your career, so it may be a challenge for you and will also take several hours. Take this project step-by-step and be aware that the project description below is written to be a bit less specific than previous Hands-Ons. The Final Project is supposed to challenge you to do some problem solving to figure out how to accomplish a task. You can always review past lessons or use a Google search if needed. Good luck!

## Setup

Create a new C# project by using the necessary command line tool, as you have done throughout this course. Name this project finalProject.

## Part 1

For this first part of your Final Project, you are going to build the game of BlingBlong! Follow the instructions below:

Create a new file named BlingBlong.cs. Within this file, create a namespace, a class, and a method to handle the following instructions:

The method should print the numbers from 1 to 100 to the console.
If a number is a multiple of three, print "Bling" instead of the number.
If a number is a multiple of five, print "Blong".
For numbers which are multiples of both three and five print "BlingBlong".
Write the necessary code within your Program.cs file to utilize the code from your BlingBlong.cs file.

Run your program and you should get the following output:

_1_
_2_
_Bling_
_4_
_Blong_
_Bling_
_7_
_8_
_Bling_
_Blong_
_11_
_Bling_
_13_
_14_
_BlingBlong_
_16_
_17_
_Bling_
_19_
_Blong_
_..._
Your output will list numbers, and their substitutions, all the way to 100. The above output only shows 1/5 of the expected output.

## Part 2

For the second part of your Final Project, you will be writing the code to create a specific sequence. Follow the instructions below:

Create a new file named Sequence.cs. Within this file, create a namespace, a class, and a method to handle the following instructions:

The method should print a list of numbers where each number is the sum of the previous two numbers. The first two numbers of the list will always be the same: 0 and 1. So, the third value will always be 1, which is 0 + 1.

The method should have one parameter that specifies how many numbers to be computed and printed. The first three values (0, 1, and 1 — from above) will always be present. The value of the parameter is for how many additional numbers to print. For example, if 8 were passed in as an argument to the method, it should print out the 0, 1, and 1, and then 8 more numbers for a total of 11. Remember, each value is the sum of the previous two (except for the initial two).

Write the necessary code within your Program.cs file to utilize the code from your Sequence.cs file.

Run your program and you should get a similar output, depending on what number is used as the parameter:

_0_
_1_
_1_
_2_
_3_
_5_
_8_
_13_
_21_
_34_
_55_
Hint! The number **8** was used as the parameter.
