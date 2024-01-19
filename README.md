# Bakery Order

A simple console application exploring the use of classes and static methods in C#

By Henry Oberholtzer

## Technologies Used

- C#
- MSTest

## Description

The bakery application prompt this was written to meet had the following objectives:

- Two Classes (Bread & Pastry)
- (Possibly inherited functionality)
- UI consists of a prompt with a welcome message, and the costs for bread and pastry
- User can input the number of loaves of bread desired, and the number of pastries desired.
- Application returns the total cost of the order

## Project Structure

```
Bakery.Solution/
├─ Models/
│  ├─ Order.cs
│  ├─ BreadOrder.cs
│  ├─ PastryOrder.cs
├─ Program.cs
Bakery.Tests/
├─ ModelTests/
│  ├─ BreadOrderTest.cs
│  ├─ PastryOrderTest.cs
```

## Setup/Installation Requirements

- .NET required for set up.
- To establish locally, download the [repository]() to your computer.
- Open the folder with your terminal and run `dotnet restore` to gather necessary resources.
- To run the application, within the solution folder, run the command `dotnet run` after the restore.
- The application will appear in the terminal.

## Known Bugs

- None at this time

## License

(c) 2024 [Henry Oberholtzer](https://www.henryoberholtzer.com/)

Original code licensed under GNU GPLv3, other code bases and libraries as stated.
