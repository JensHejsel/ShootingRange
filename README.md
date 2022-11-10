# ShootingRange

Mini project for programming of interactive 3D worlds: Shooting Range

The idea for the game:
The idea is to make a game containing a shooting range that the player can use. When the game launches, the player should spawn in the shooting range with a gun in their hand. The player should be able to move around the shooting range with the WASD keys and should be able to look around using movement of the mouse. The player should receive information on how to start the game on screen and should be able to execute whatever action is needed to start the game. When the game starts, a target should spawn within the predetermined area in the shooting range. The player should have 30 seconds to shoot as many targets as possible. The target should relocate every time the player hits the target and the player’s point should go up by 1. If the player shot and missed the target, a bullet hole should spawn at the destination of the player’s crosshair and the player’s points should go down by 1. Once the 30 seconds have passed, the game is over and the players score should be presented on the screen for the player to see. The information upon how to start the game is once again presented on the screen and the game can now be played again.

Project parts:  
•	Script 1: PlayerBehavior – Defines how the player moves and looks around.  
•	Script 2: GunBehavior – Defines how the gun shoots.  
•	Script 3: GameBehavior – Defines how the timer and score work.  


•	Object 1: Main camera – The player and POV. Also functions as the gun, as a ray is being cast from the camera towards the middle of the screen whenever the player shoots.  
•	Object 2: Canvas – Used for visualization of score and timer.  
•	Floor and walls/ceiling – Used for making the building.  
•	Table – Used to keep the player from entering the “Target spawn area”.  
•	Gun – Used to visualize the player’s gun.  
•	Spheres – Spawns at the destination the player shoots to visualize bullet holes.  
•	Point light – Used to light up the room.  

•	Material 1: Brick – Used on the walls.  
•	Material 2: Wooden planks – Used on the floor.  
•	Material 3: Steel – Used for the “don’t move further” table.  

Time schedule:  
•	Coding the “PlayerBehavior” script: Approx. 1 hour.  
•	Coding the “GunBehavior” script: Approx. 3 hours.  
•	Coding the “GameBehavior” script: Approx. 1 hour.  
•	Building the building with ProBuilder: Approx. 30 minutes.  
•	Finding different materials, a gun and a target on the Unity Asset Store: Approx. 30 minutes.  
•	Adjusting materials, positioning of objects, size of objects and POV: Approx. 1.5 hours.  

Used material:  
•	AAU Library, Unity in action book – Used for implementation of the PlayerMovement script.  
shorturl.at/aqF13  
•	Youtube, Brackeys – “LIGHTING in Unity” – Used for making the lighting in the game.  
shorturl.at/b1278  
•	Youtube, Brackeys – “How to BUILD / EXPORT your Game in Unity”  
shorturl.at/hjN38  
•	Youtube, Nathan Jenkins – “Player Audio Clips through your Code in Unity”  
shorturl.at/gpQSZ  
•	Youtube, Dani Krossing – “HOW TO ACCESS DATA FROM ANOTHER SCRIPT”   
shorturl.at/JNQUW  
•	Youtube, The RealTime Essentials – “Creating Your FIRST LEVEL in Unity with ProBuilder”  
shorturl.at/HOQT3  
