# Lesson 6 Hands-On

## Directions

For your Lesson 6 Hands-On, you will be practicing your new C# skills with Namespaces and Using directives. In this Hands-On exercise, you will create a program which will test your newly acquired knowledge of C# programming. This Hands-On will be graded, so be sure you complete all requirements listed below. Follow the below steps for setup.

## Setup

Open up your command prompt/terminal.
Run the following to navigate to your Desktop
_cd desktop_
Navigate into the ProgrammingC# folder:
_cd ProgrammingC#_
Next, the following command is the CLI command to create a new project:
_dotnet new console -o lesson6HandsOn_
Once the process is complete, navigate into the lesson6HandsOn directory:
_cd lesson6HandsOn_
Lastly, run the following to open your new project in VS Code:
code .
For this Hands-On, you will be working within the **Program.cs** file. Good luck!

##Requirements
Create another file named **AnotherProgram.cs**.
Within **AnotherProgram.cs**, include the following:
The necessary using statement for System
A namespace named **myNamespace**. Within this namespace add the following:
A class named **AnotherProgram**
Add a method within the class named **printText** that prints _"Hello Earth!"_ to the console.
Again within the AnotherProgram.cs file, create another namespace.
Give this namespace a unique name.
The namespace should have a class that includes a method.
The method should have a unique print statement.
Using the using keyword, make both of the namespaces from **AnotherProgram.cs** available to the **Program.cs** file using aliases.
Within the Main method in **Program.cs**, call each of the methods from the namespaces in **AnotherProgram.cs**.
Your final output should look similar to the following:
_Hello World!_
_Hello Earth!_
_I am text from the textNamespace._
