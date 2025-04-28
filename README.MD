For this project it took me a lot of brainstorming to figure out what I wanted to do. I managed to come up with the idea to make a terraria mod. This project and mod was fun to work on and gave me my first experience with modding. 

My mod is called 
***

# RV's Content Mod

The main aspects of this mod is that it adds items. There are 10 diffrent items that I created. I saddly didn't have enough time to add any npcs or bosses.
I still think I did a good job with no experiance to modding or c# which is the language the game uses. 
#### There are a few sources and sites that I found extremely helpful in creating and researching for this mod. They will be linked below. 
Some hardships I encountered were 1. (Projectile troubles) The projectile I created has the same exact AI as an arrow would. 
This lead to a problem were the arrow would spawn in then just fall to the ground and despawn. Not exactly what I had in mind. 
I quickly relized that the arrow didnt have velocity because it was spawning in and being affected by gravity just not moving forward. 
I tried for an hour or so before I figured out how to give the arrow velocity using the class Item and the field shootSpeed.
So all I needed to do was give the item that was shooting the projectile the simple line of "Item.shootSpeed = 10f;" and it would instantly work. (I was very angry by how simple it was)
Another hardship was the dreaded (armor ser bonus incident) were I was making a set bonus for my CondensedGel armor but nothing was changing when I reloaded.
After hours of messing with things I finally looked into the cheat sheet menu to see. There were two sets of items in there. 
I went to hover over them and saw that when I changed the name of my mod and all the internal namespaces I never quit my game.
This caused some type of bug that even though they were the same items they duplicated and there was a "tutorial" set and a "RVSContentMod" set.
"tutorial" was the original name of the mod because when you look at the github guide it says to call the first mod you make that.
After I closed my game no more doppelganger happenings. 
These where the only real trouble that I had with modding. 
Although it was a pain to color all the sprites in.
I found a really cool sprite design site called "Piskel", Piskel was a real life saver and made it a lot easier to import and export the sprite sheets I used and made.









https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide
https://terraria.fandom.com/wiki/Terraria_Wiki
https://forums.terraria.org/index.php?forums/
https://docs.tmodloader.net/docs/stable/index.html
https://www.piskelapp.com/
https://youtu.be/Zf46rsYkTrs?si=nTJJfJ-iaOzdW5vd
https://youtu.be/7tcxaKhhVsc?si=oeAJcsbjnWkTrhG6
https://www.youtube.com/watch?v=Ov7JUsWt2xE
