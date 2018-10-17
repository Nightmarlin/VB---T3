Mr Albanozzo,

As you can see, this has taken up waaay too much of my time to be healthy, and as such I feel
	that you should probably take the time to read this to understand just how much I put
	into this without having to find it all yourself.

1 - Playing the game
Click Start game / Click File->New Game / Right Click->New Game
Enter the player names (Cancelling will return them to what they were before)
By default O goes first, but this can be changed
Click on the squares you wish to move to like in normal T3 
	or click 'End Game' / Right Click->End Game / any of the start game options
When a game is played to completion [Draw or Win], you will be able to save the replay.
	Clicking 'Yes' will save the file as *.T3Replay in the file path saved in memory
	(more on this later)
To change player names, simply click 'Change Names' and type the new names
	The first name is Noughts, the second is Crosses
Trying to click on a filled square will result in a message telling you off
Hovering your mouse over an empty square will display an icon showing that you
	can move there

2 - Replays
Possibly the more complicated of the four forms as it manages to spread its
	greasy palms over the entire game, this is the one that took up most
	of my time
To begin, do any of:
	Select 'Replays' from the context menu,
	Select 'Replays' from the main menu,
	Drag a '*.T3Replay' file over the game form,
		-> For these two, click 'Select a file' on the Replays form
	Drag a '*.T3Replay' file over the Main Game or Replays forms,
	Drag a '*.T3Replay' file over the 'T3.exe' itself
		-> As the files are loaded upon dropping, there is no need to
		   select one
Then, to navigate, you can use:
	The buttons - 1ST, PREV, NXT, LAST
	The TrackBar
	The WASD Keys 
		W - To First move
		A - To Previous move
		S - To Last move
		D - To Next move
	The number keys (not the NumPad) to jump to the corresponding move
If you notice flickering, this is because the application refreshes and then
	redraws the panel each time the move index is changed for easier
	coding
Clicking 'Select a file' or DragDropping a new '*.T3Replay' onto the form will
	allow you to load a new Replay file

3 - Settings
AutoSave Replays: [Default: False]
	Determines whether or not the game asks if you want to save the replays
	Checking the box will make the game save replays by default, unchecking
		it will result in the game asking you after each game
Noughts go first: [Default: True]
	Determines which player goes first
	Checking the box will allow 'Player 1' (or equivalent) AKA Noughts to go
		first, unchecking it will allow 'Player 2' (or equivalent) AKA
		Crosses to go first
Save Folder: [Default: Application's start folder]
	Change:
		Allows you to select a new folder to save the replays to
	Reset:
		Resets the save folder to the application's start folder
Themes:
	>>> NOT GONNA HAPPEN
	>>> DUE TO = {
		"General Laziness",
		"A Distinct Lack of Effort",
		"Evaluation: Unnecessary",
		"A Need for Sleep"
	}

4 - Help
Open the form using any of:
	The context menu
	The main menu bar
	F1 [If you are on the either the Replays or Main Game forms]
Click on one of the buttons to recieve help on the relevant subject
As you can probably expect, there will be no help given on how to access help

Thank you for your time, and I hope you enjoy this take on Noughts and Crosses