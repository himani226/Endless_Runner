# EndlessRunnerGame
 Endless Runner game has been developed in Unity3D Game Engine

It is a simple game where player run endlessly and hit the coin to get the scores. Arrow keys will be used for move Left and Right. Space Bar will be used to jump the player.

Unity3D version: 2021.3.6f1 

There are seven scripts to handle the Endless Runner Game

1. PlayerMovement: To handle the movement of the player to left, right and jump with arrow keys and spacebar.
2. GroundPlane: To handle the random generation of ground plane, obstacles and coins, then destroy it later.
3. GroundMaker: To handle the placment of new ground at the end of earlier ground.
4. CameraFollow: To handle the camera position to follow the player.
5. GameManager: To handle the Scores display on top of the game.
6. Obstacle: To handle collision of player and obstacle, when player hits the obstacle player should die. 
7. Coin: To handle the creation of coins and when player collided with coin, the coin destroy and update the score.