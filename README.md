# Crossout-Grid

## The project: Crossout Grid

### Make a simple game where:
* the game generates a grid 4x4 with values between 1 and 11.
* the player can choose which cells to pick to collect 21 points.
* Ex: picking 3 cells with 3, 7, and 11 gives the player 21 points.
* those cells should work as toggles (single click selects a given cell and a second click deselects the cell)
* if the player exceeds 21 points (selects cells worth more than 21 points) he loses the value of selected cells divided by 2.
* Ex: a player picks cells with the following numbers 4, 6, 3, and 10 which gives the sum of 23, the game will divide that value by 2 which equals 11 (we’re using int values here). This value (11) will be subtracted from the player's score.
the game finishes when the player scores 60 points.
* The whole project can be made using only UI components.


### Requirements:
* Singletons are not allowed.
* Avoid using too many GetComponents.
* Separate logic from displaying - very simplistic MVC.
* Consider using Unity Events.



https://user-images.githubusercontent.com/76531899/167291999-ea901cf3-b812-4ff3-a8d3-908fc5d36df0.mp4

