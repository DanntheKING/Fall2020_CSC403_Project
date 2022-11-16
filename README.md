# Fall2020_CSC403_Project




## Amiyah Frierson

> Sprint 1

###### Main Menu
To create the main menu, you have to create a new Windows Form and call it in Program.cs, replacing Application.Form(new FrmLevel()). In the designer window, I added 3 buttons that would start and quit the game, and open settings. Opening settings and starting the game is just a matter of Form.Show() and quitting the game closes the form that the application runs with.   

###### Sounds 
I added sound to the game with SoundPlayer class. I added two new songs (one for the boss and one for the non-bosses) and a walking sound effect. I then added these to this project’s resources. This way you don’t have to have a specific file location for the source of the music files; especially helpful since the project is opened on different devices. 

###### Settings
Create a new Windows Form that is called to show when you click the settings button in the main menu. The only button I added here in the designer was the “go back” button. I also have “full window” and “music on/off” settings as checkboxes. These settings were made to work across all forms by maximizing the game window when checked and carrying the “musicOn” boolean to when any FrmBattle opens.  

> Sprint 2

###### Health Bar
I created a label that displays the player character's health. To change the color of the health as it got lower, I created static variables that represented the player's health at 60% and 30%. When the player reaches 60% health, the label will be colored orange. When you reach 30%, the label will be red. Otherwise, the player's health is considered to be "okay" and remain green. 

###### Enemies Remaining Counter, Death, & Win Screen
Created a new Windows Form that appears under the condition of the player's health reaching 0. It will close all other forms and give the player options to retry or restart. 

I added a new label that displays the number of enemies on the map (unchanged from 4). Using the condition of when the enemies are made invisible, I counted down the number of enemies remaining. When this counter reaches zero, a "Win" screen will appear, closing all other forms and allowing the player to play again or quit the application. 

###### "Pause" Form
Created a pause menu that appears when you hit the escape key. It only allows you to resume the game (hiding this pause form) or quit to the main menu. 

###### Scaling Issues
There is an issue where the game has different scaling across hardware. I attempted to fix this by disabling the AutoScaleMode property on all the Forms that had this issue. 

## Daniel Davis:
1.) Added the heart image that will be shown the map to so the player has a visual image of a heart
2.) I placed the heart on the map so the player can walk over the heart to gain health points
3.) I made the heart worth 5 health points

> Sprint 2
1.) Added more hearts to the game to give player more hp in one round
2.) Added armor to the game so the player can have more resistance while fighting the enemies
3.) Made the characters dissappear when the enenies HP=0







## Frankie Lavall: 
SPRINT 1
Weapons
1. I added 3 different weapons to the game which are ak47, m16, sniper. I added a picture box to the FrmLevel.Designer.cs file which is called PicGun. It creates a box that holds pictures of each weapon. I also added the images of weapons and player holding weapons to the resource.resx and added code for each weapon to the Resource.Design.cs file. All of these steps allow the images of the items in need to be used in code.
2. I then added a variable to the FrmLevel.cs file that randomly iterated a list to pick which weapon would show up in the level. Then used the HitAChar function to determine when the player collides with the weapon. I also made a BoostAttack function to use when ever the weapon is picked up and you are in a fight sequence.
Weapon Inventory
1. I also added a inventory window that shows the weapon that you have picked up using a picturebox window.

SPRINT 2
Bigger Map
1. I made the objects and characters smaller using the FrmLevel.cs(design) file. It allowed me to move objects around easily and it updated the code on its own. I moved objects and also added more objects in that file. 
2. I also changed the type of bricks that were used in the game just to give it a different look. I added that new picture to the resource files in order for me to add it to the designer files.
Player Sprint
1. I added a function that would allow the player to sprint when the left or right shift key is pressed using the ControlModifier function.








## Keiser Dallas: 
1. I added the retreat button to the battle screen. When clicked, it updates the current health bars of both characters and closes the battle window if both players are still alive.
2. I added the counter button to the battke screen. When clicked it subtracts (-1) health from both player and enemy.
3. I added the finisher button to the battle screen. If the enemy's health is beneath 10 and the player has more health than the enemy, then clciking the button subtracts (-6) health points from enemy. 
4. I created another public variable to the enemy class called 'Boss,' with public get and set, to assign a specific enemy as the boss of the level.
5. I added a conditional statement to the 'GetInstance()' function that increases the enemies max health and health to 60, instead of the normal 20. 
6. I created two windows forms that display dialogue between NPCs and the playable character.
7. I added two NPCs to the map, and when the player interacts with them it displays a dialogue scene between the player and NPC.
