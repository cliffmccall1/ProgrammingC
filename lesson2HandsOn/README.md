## Setup

Open up your command prompt/terminal.
Run the following to navigate to your Desktop
_cd desktop_
Navigate into the ProgrammingC# folder:
_cd ProgrammingC#_
Next, the following command is the CLI command to create a new project:
_dotnet new console -o lesson2HandsOn_
Once the process is complete, navigate into the lesson2HandsOn directory:
_cd lesson2HandsOn_
Lastly, run the following to open your new project in VS Code:
_code ._
For this Hands-On, you will be working within the Program.cs file. Good luck!

## Part 1

Create a program which prints the ticket prices for a user:

If the user is a senior citizen (they are 65 years of age or older), they receive a discounted price of $7 per ticket.
If the user is 12 years of age or younger, they receive a discounted price of$8 per ticket.
Otherwise, they will pay \$10.

**Age Range Price**
_0-12 \$8_
_13-64 \$10_
_65 & Above \$7_

Print the ticket prices to the console.

## Part 2

Add the following to your program that prints the ticket prices for a user:

Create a new variable named isStudent that is of type boolean.
Set this to true to test your code.
Add another condition to the statement(s) checking for the age of a child. It should now be the following:
If the user is 12 years of age or younger OR a student, they receive a discounted price of \$8 per ticket.

**Age Range Price**
_Student \$8_
_0-12 \$8_
_13-64 \$10_
_65 & Above \$7_

## Part 3

Add the following to your program that prints the ticket prices for a user:

Add another test that checks for any negative values for the variable age. If age is indeed set to a negative value, print _"Invalid age"_ to the console.
