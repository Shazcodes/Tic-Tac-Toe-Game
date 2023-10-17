# Tic-Tac-Toe-Game
A simple console-based Tic-Tac-Toe game implemented in C#.

Features
Two-player game mode.
Players take turns to mark their respective symbols (X or O) on the board.
The game checks for a win or a tie after every move.
Clear and intuitive console display of the game board.

How to Play
The game starts by displaying the board with numbered positions.
Player 1 starts with the symbol 'X' and Player 2 uses the symbol 'O'.
Players take turns to input a number corresponding to the position they want to mark.
The game continues until there's a winner or the board is full, resulting in a tie.

Code Structure
The main logic of the game is contained in the Program.cs file. Key functions include:
DrawBoard(): Displays the current state of the game board.
checkwin(): Checks if there's a winning condition or a tie.
Drawx(int pos) and Drawo(int pos): Mark the respective symbols on the board.

Running the Game
To play the game, compile and run the Program.cs file using a C# compiler or an IDE that supports C#.
