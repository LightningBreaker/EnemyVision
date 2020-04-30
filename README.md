# CPSC 481 Project submission
# Enemy Vision AI for 3D Games

A game is more challenging when the player is encountered by enemies that possess some intelligence. Hence, a good start to creating a stealth game will be building an enemy AI by granting enemies the power of sight. The AI is applied as a probabilistic path-finding approach to efficiently analyze a 3D space and find stealthy paths. This approach naturally accommodates variation in the level design, numbers and movements of enemies, fields of view, and player start and goal placement. 

This design is integrated directly into the Unity game development framework, allowing for an interactive and highly dynamic exploration of how different virtual spaces and enemy configurations affect the potential for stealthy movement by players, or other non-player components.

The artificial intelligence algorithm used will allow the enemy to detect the position of the player when the player comes inside the vision cone of the enemy. This define the enemy's as well as player’s behavior and perform actions such as chase or attack. This is achieved by creating a cone of vision display that adapts to obstacles and defines the enemy patrol behavior. 
I consider this project idea as a cool idea because for the first time I am not on the player’s side, rather I am looking for making the enemies of a game powerful by providing them a field of vision to catch the player. 


## Getting Started
3D Game Scene created inside following path:
AI_Project\Assets\AI_Assets\EnemyVision\Demo\Scenes\Stealth3D

### Prerequisites

For building the project correctly, Unity version 2018.4.17f1 is required

### Executing Game
-Execute AI_Project.exe
-Select appropriate resolution and windowing
-Click Play

## Deployment and Build
> This game can be deployed as a desktop and mobile application using Unity build creator

- Go to Unity > File > Build Settings

- Add open scene

- Choose the build type (Android, Windows, Linux)

- Click on build

## Contributing

Please contact gunjangupta592@gmail.com for details on code of conduct, and the process for submitting pull requests to us.

## Versioning

Used github for version control. 

## Authors

* **Gunjan Gupta** - *Initial work* 

## Acknowledgments

* I would like to acknowledge Unity tutorials and its asset store for the texture and artwork used in the Game 
* Inspiration from Unity AI assets


## Game Snapshot
https://user-images.githubusercontent.com/60246830/80645352-d3c8e880-8a1f-11ea-817f-864fc1f51f77.png

## Code Scripts
Path : AI_Assets\EnemyVision\Scripts


• GameManager – Manages communication with different components of the game.

• Invisible – This script manages the visibility of the game won symbol. It enables the green tick when the player reaches the goal point and end the game.

• GameWon – Handles the winning of the game by displaying the tick image and restart when the goal is achieved

• KillPlayer – Handles the collision of enemy with the player. If this happens, the game gets over.

• Enemy - Basic enemy script that manages character movement and rotation. The 3D version is also compatible with Unity’s navmesh pathfinding.

• EnemyPatrol – This script will enable the enemy to move along a specific path. Patrol points can be set to select the path where the enemy can move.

• EnemyFollow – This script will enable the enemy to follow the target player.

• EnemyLOS - It creates an enemy vision display (red cone) and looks for the player (VisionTarget). It will swap from the action EnemyPatrol to EnemyFollower when a target is detected. The enemy vision range and vision angle can be adjusted. A vision mask can be used to choose which layers affect the vision.

• EnemyVision - This must be attached to the enemy vision (red cone) instead of the enemy itself. EnemyLOS will spawn an EnemyVision cone for each enemy at the start of a scene. These scripts will change the shape of the visual display based on obstacles in the scene. To help with optimization and frame rate, you can change the number of points that will create the cone (precision) and the refresh rate.

• VisionTarget – Script to the player object that is needed for EnemyLOS to detect as a target. When this object is seen, EnemyLOS will change from EnemyPatrol to EnemyFollow.

• EnemyDemo - This script is specific to the demo scene; it just handles animations and events. 
