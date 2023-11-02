# Tic-Tac-Toe Game

Welcome to the Tic-Tac-Toe Game project! This is a simple console-based game implemented in C# that allows two players to enjoy the classic game of Tic-Tac-Toe.

## Features

- **Two-Player Game Mode**: The game can be played between two players taking turns.
- **Console-Based Interface**: The game is run in the console for easy play and understanding.
- **Game Board Display**: The board is displayed in the console with clear markings for each player's moves.
- **Win and Tie Detection**: The game automatically detects a win or a tie and announces the outcome.
- **Input Validation**: Players' inputs are validated for correct format and unoccupied spaces.

## How to Play

- The game board is displayed with positions numbered from 1 to 9.
- Player 1 uses the symbol 'X' and Player 2 uses the symbol 'O'.
- Players input the number corresponding to the position they want to mark.
- The game continues until a player wins or all positions are filled, resulting in a tie.

## Code Structure

The main logic of the game is contained within the `Program.cs` file. Here are some of the key functions:

- `DrawBoard()`: Displays the current state of the game board.
- `checkwin()`: Checks for a winning condition or a tie.
- `Drawx(int pos)` and `Drawo(int pos)`: Marks the respective symbols on the board.

## Running the Game

To run the game, you need to compile and execute the `Program.cs` file using a C# compiler or an IDE that supports C# development.

## Programming Language

- **C#**: The game is entirely written in C#.

## Repository Content

- [`README.md`](https://github.com/Shazcodes/Tic-Tac-Toe-Game/blob/main/README.md): This file, containing the project documentation.
- [`Program.cs`](https://github.com/Shazcodes/Tic-Tac-Toe-Game/blob/main/Tic%20Tac%20Toe/Tic%20Tac%20Toe/Program.cs): The main C# source file with the game's logic.
