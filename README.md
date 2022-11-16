# Fall2020_CSC403_Project




## Amiyah Frierson

###### Main Menu
To create the main menu, you have to create a new Windows Form and call it in Program.cs, replacing Application.Form(new FrmLevel()). In the designer window, I added 3 buttons that would start and quit the game, and open settings. Opening settings and starting the game is just a matter of Form.Show() and quitting the game closes the form that the application runs with.   

###### Sounds 
I added sound to the game with SoundPlayer class. I added two new songs (one for the boss and one for the non-bosses) and a walking sound effect. I then added these to this project’s resources. This way you don’t have to have a specific file location for the source of the music files; especially helpful since the project is opened on different devices. 

###### Settings
Create a new Windows Form that is called to show when you click the settings button in the main menu. The only button I added here in the designer was the “go back” button. I also have “full window” and “music on/off” settings as checkboxes. These settings were made to work across all forms by maximizing the game window when checked and carrying the “musicOn” boolean to when any FrmBattle opens.  






## Daniel Davis:
1.) Added the heart image that will be shown the map to so the player has a visual image of a heart
2.) I placed the heart on the map so the player can walk over the heart to gain health points
3.) I made the heart worth 5 health points







## Frankie Lavall: 
1. I added 3 different weapons to the game which are ak47, m16, sniper. I added a picture box to the FrmLevel.Designer.cs file which is called PicGun. It creates a box that holds pictures of each weapon. I also added the images of weapons and player holding weapons to the resource.resx and added code for each weapon to the Resource.Design.cs file. All of these steps allow the images of the items in need to be used in code.
2. I then added a variable to the FrmLevel.cs file that randomly iterated a list to pick which weapon would show up in the level. Then used the HitAChar function to determine when the player collides with the weapon. I also made a BoostAttack function to use when ever the weapon is picked up and you are in a fight sequence.
3. I also added a inventory window that shows the weapon that you have picked up using a picturebox window.







## Keiser Dallas: 
1. I added the retreat button to the battle screen. When clicked, it updates the current health bars of both characters and closes the battle window if both players are still alive.
2. I added the counter button to the battke screen. When clicked it subtracts (-1) health from both player and enemy.
3. I added the finisher button to the battle screen. If the enemy's health is beneath 10 and the player has more health than the enemy, then clciking the button subtracts (-6) health points from enemy. 
4. I created another public variable to the enemy class called 'Boss,' with public get and set, to assign a specific enemy as the boss of the level.
5. I added a conditional statement to the 'GetInstance()' function that increases the enemies max health and health to 60, instead of the normal 20. 
6. I created two windows forms that display dialogue between NPCs and the playable character.
7. I added two NPCs to the map, and when the player interacts with them it displays a dialogue scene between the player and NPC.
