# 2D-Infinite-Runner-DATT2300
This is the code for  a 2D infinite runner developed as non for profit in DATT 2300 at york university.
 This project is called Mirage Derp because it is an endless runner game about my friend from high school. You can use the left mouse click to jump, or the space bar, and there is a double jump if you press [space] then [space] or [left click] then [left click]. The points system works as you will get points for travelling any distance as well as a bonus 100 points for any coin you pickup. The platforms, coins and powerups spawn in from a random pool of object prefabs in random spots with a min and max range of course to make the placements fair. 

If you fall off screen you die and if you hit a spike you die and reset. There are two working powerups in this game, the green jem destroys all spikes making the game safer for 10 seconds and the blue gem increases point pickup by x2 even for coins. All objects spawn using a random algorithm developed while doing Gamesplusjames tutorial on youtube plus my own tweaks for optimizability, to the C# code.

I did not have enough time to add three lives, most endless runners don’t give this to you anyways, the initial plan was to have 3 playable characters and each time 1 died the other ones would come out to continue. This was my creative approach to a life system, but it was scrapped as the sprites were too detailed and I was losing time. The game also records the most previous Highest Score. The 2 enemy objects were changed to have 1 spike object and 2 power-ups.
