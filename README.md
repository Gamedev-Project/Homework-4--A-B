# Spaceship Game and Triggering in Unity

![](https://i.imgur.com/AaSLWLT.png)

## Hello and welcome to our Unity based game Spaceship war in the framwork of Game Dev!

in this game you are the Spaceship and you have to avoid the Portals and shoot them.
you have 3 strikes - if you hit a portal your life is downgraded by 1.

the Spaceship have the ability to shoot the portals with laser and with every successful shot you earned yourself 1 point.

we have several scenes and each one is focused on another trigger.
we got the base game in scene 1 so we will begin from scene 2, The homework assigminet which we follows is [right here!](https://github.com/gamedev-at-ariel/gamedev-5781/blob/master/04-unity-triggers/homework.pdf)

### Scene 2
in this scene we were asked to add an improvement to the game, we decided to add 3 live strike to the spaceship that the game will give you second and third chance to help on the game.

![](https://i.imgur.com/t7JLumf.png)

here you can see the 3 hearts on the right side of the spaceship

we added 3 child gameobject of heart to the spaceship and then on the [collision script](https://github.com/Gamedev-Project/Homework4-A-B/blob/main/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs) we took the component children renderer and disabled them within evrey hit when the trigger entered.

### Scene 3 
in this scene we were asked to implement boarder to the screen which the Spaceship will not allowded to pass.
we added 4 box-colider gameobject green boarders and edit them on layer "Boarder".

![](https://i.imgur.com/ixmCZJ2.png)

we inserted [raycasthit2d](https://docs.unity3d.com/ScriptReference/RaycastHit2D.html) object which tells us if our spaceship has hit something with the Layer "Boarder" and if it does hit something it will not let it pass and just let it move the other directions but not pass the boarder.
we did the same thing on horizontly walls and vertically walls. The code associated is [right here!](https://github.com/Gamedev-Project/Homework4-A-B/blob/main/Assets/Scripts/1-movers/KeyboardMover.cs)

### Scene 4
here we were needed to create a Destroing boarder in the vertical view to the portals and the lasers from the spaceship.
we updated the down-wall and up-wall to there own tag and inserted in the [Mover script](https://github.com/Gamedev-Project/Homework4-A-B/blob/main/Assets/Scripts/1-movers/Mover.cs) (for the laser) and in the [Destroyon2DTrigger](https://github.com/Gamedev-Project/Homework4-A-B/blob/main/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs) Script (for the portals) the collision for this incidents and Destroy command for destroing the Laser/portals when they collide.

### Scene 5
we were requested here to implement an legality of "open world" so we took it from the camera view of the boarders with the command ["ScreenToWorldPoint"](https://docs.unity3d.com/ScriptReference/Camera.ScreenToWorldPoint.html) which Transforms a point from screen space into world space and when you hit the right/left boarder you will transform your position to the left/right position Respectively.
The code associated is [right here!](https://github.com/Gamedev-Project/Homework4-A-B/blob/main/Assets/OpenWorldMover.cs)

## Game Link
And of course, scene 4 is up and ready to play [Right here!](https://aviniv.itch.io/spaceship-boundaries)

###Hope you Like it! Niv & Avi!!
