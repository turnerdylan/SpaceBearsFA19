# SpaceBearsFA19
## Final Project for Team Space Bears in ATLS4040: Game Development
 ---
 ## Game Sound 12/3/19
 
As we approach the end of the semester we are starting to polish our project into the passion project our team has envisioned. One area we are looking at now is the sound design of the game. Currently we aren't expecting any limitations on file size as our game isn't too massive, we will be using BFXR to create our sound effects and FL Studio to create our soundtrack both of which will be exported as WAV files. Below is our current sound design plans.

Player Sounds:
- Jumping: Cute sounding jump effect
- Walking: Soft pitterpatter on various materials.
- Instrument Powers: each instrument will play along with the soundtrack whenever their button is pressed (we would also like to add a button to just stand still and play the instrument for no reason if time allows for it. Because jamming out is the best)

Global Elements:
- Ambient Soundtrack: The soundtrack will be simple and space themed and will be in compliment to the bears various instruments
- Diegetic Sounds: we will need various sound effects for objects in the world such as switches, buttons, doors, fans, and other objects. The sound effects will be designed such that players know when they are interacting with an object.

Menus:
- Sounds: navigation blips to notify the player of when they are interacting with UI elements
- Music: Title screen music which features all of the instruments from the game with a cutesy space feeling

  ---
 ## Animations and Levels Update 12/1/19
 
 If anyone was worried about how cute the bears would look while walking, take a look at this!
 <img src="https://github.com/turnerdylan/SpaceBearsFA19/blob/master/Process/B-WalkRightAnimation.gif" width="50">
 ![C-Walking](https://github.com/turnerdylan/SpaceBearsFA19/blob/master/Process/C-WalkRightAnimation.gif)
 ![DN-Walking](https://github.com/turnerdylan/SpaceBearsFA19/blob/master/Process/DN-WalkRightAnimation.gif) 
 
 We got through integrating all the left and right movement and jumping animations post-Thanksgiving after making those animations earlier during the holidays. The next step was to try our hands at making some levels!
 
 
 
  ---
 ## Bears, Bug Fixes and Levels 11/20/19
 
 We finally have our Bears!
![BearSprite](https://github.com/turnerdylan/SpaceBearsFA19/blob/master/Process/TheBears.png)
 The long awaited release of the bears is finally here! As described in the Characters Update, we now have our basic bear sprites to play with in our game. Animations will be coming in the next week or so and we are very excited for that. We have created a list of the animations we want including some basic walking in either diretion, jumping, jumping while walking and using the instruments. More will proabbly get added to this list. 
 
 We are still working on a few bug fixes but on the whole, all of the player mechanics for the game are complete. Woo! The next steps will be implementing the level specific mechancis like levers, doors, transitions, and allowing the players to pick up/use objects and items in the world.
 
 Speaking of levels, we have the first 4 introductory levels drawn out and created in the game using the tilemap we implemented a week ago. The first level is simply an introduction jump stage, followed by 3 levels that are designed to be solved using each instrument's power. This allows each player to get a feel for their instrument and practice using it to solve a specific problem. In later levels we can come back to these intial uses and the player will know what to do, which combined with a new scenario creates a fun puzzle space. A space puzzle space.
 
 Go Space Bears!
 
 
 ---
 ## First Prototype and Tilemapping 11/13/19
 
 After our organization meeting and distribution of tasks, we met up again to work on the implementation and some initial bug fixes. It It looks like our controller set up will work via a bluetooth connection with ps4 controllers. The keyboard controlls map well to the controller and one of our team members could control the characters from the working prototype separately which is promising. 
 
 Also the working prototype is working! Minus a few bugs each instrument has directional control and fires out in a beam using ray casting. The characters feel like you expect them to and the time, size, and force physics are all up and running which is awesome! 
 
 Lastly, the first set of tilemapping sprites was completed and put into Unity with the Tilemapping feature successfully so we can now begain to create the platforming levels easily. 
 
 All of these things combine to leave us in a great position to start designing levels and creating puzzels. It's happening!
 
 ---
 ## Team Organization & Logistics 11/11/19
 
 Now that we have our game idea fleshed out, it is time to start making our game. We started this week with organizing the current tasks, outlining the goals for the next few weeks and distributing responsibilities. To facilitate this we set up a Gantt Chart and Trello board with the goal of narrowing our usage down to one of these platforms after figuring out which we prefered to use.
  
  Our list of tasks for this week include some controller configurations and connectivity, an initial set of tilemapping sprites and some working mechanics protoypes for our instruments and characters.
 
 ---
 ## Instruments and Story 11/7/19
 
 1. Time Trumpet
 A directional beam that freezes an object or world item in place for a set duration after which the object unfreezes and is affected by physics again. Can freeze multiple objects at a time. 
 
 2. Size Saxophone
 A directional beam that doubles or halves the size of an object or world item. Can freeze multiple objects at a time.
 
 3. Force Flexaton
 A directional beam that pushes or pulls objets and world items in a straight line between the objects position and the Flexaton. Like a tractor beam and mass dependant. 
 
 Story!
 This three bear band is headed to the biggest jam fest this side of the milky way when their space bus crashes! Help repair the ship in time with your trusty instruments and get to that music festival!
 
 ---
 ## Characters! 11/5/19
 
Since we are team Space Bears, our multi-player cooperative puzzle game has four characters who are various bears. Big surprise. The crew consists of:
 
Beethoven|Cherry|Doug Norton
---|---|---
The jazzy one|The cute one|The sleepy one
Plays the Time Trumpet|Plays the Force Flexaton|Plays the Size Saxophone
Is a polar Bear|Actually a Koala (not a real bear)|Is a panda bear
Wears a bow tie|Wears a big bow on one ear|Has an umbrella
Snaps fingers to a beat when idle|Is a crybaby|Fluffy
Short and squat|A support character (emotional support)|Is actually a news anchor
 
 ---

## Furthering the Concept 10/30/19

We discussed as a team the basic direction that we wanted our game to go in. This included our Design Values and our Core Mechanics.

Design Values:
- Teamwork / Coordination
- Challenging Puzzles
- Cuteness
- Fun and Brain Bendy Situations

Game Mechanics:
- Physics Altering Musical Instruments
- Spatial Puzzles
- Traps and Obstacles

After setting these goals for the development of our game we dug into some other aspects of the game that still needed fleshing out like player abilities, obstacles and world items, our core instrument ideas and how the instruments interact with the world or other objects. 

The basic player abilities we want include walking/running, a short jump, using their instruments & potentially picking up objects or interacting with objects. Other abilities like sprinting or crouching probably won't impact how our players will interact with the game so they aren't immediately necessary. 

Another topic we tossed around was the size of the characters, at the moment it looks like the main 4 characters will be Bears so their height and width probably won’t change between each character. We discussed having different animals and each of them being a different size, but we decided that changing each of their sizes would impact how they interacted with the platformer and added a layer of complexity to our lives that we probably don't need. 

The obstacles and items we want to implement include lasers, buttons, doors, switches, portals, boxes and electricity. This is just our initial list.

The instruments are probably the most exciting part of our game and we have semi-narrowed it down to 4 concepts. We want to include instruments that change time/speed, size, gravity/rotation and forces. This is also our initial list for this and probably will get revised as we home in on the specifics and limitations of each instrument. 

One other aspect that we still need to discuss further are the interactions between the instruments and the thing that they are affecting. Can you change the size of a player from anywhere on the map or do you have to be standing next to them or do you have to be within line of sight? The same questions apply to interacting with an object and there are similar but still to be discovered questions about interacting with the world.

There are still many questions to iron out, but we are on the way to answering them!

---

## Initial Ideation 10/23/19

The dust has settled from our huge class brainstorm and a team has emerged. Team Space Bears!
The working design includes a CO-OP Animal Astronaut Magical Musical Puzzle Adventure Game. Just that. Potentially astronaut bears but it is still getting ironed out. We want to create a visually and complexly simple game with some interesting mechanical depth... if that exists.
Our ideas now involve a multi-player game with each player coining a unique ability through the power of magical space instruments. Ideas include:
  - The Time Trumpet
  - The Size Saxophone
  - The Gravity Guitar
  - The Speed Synth
  - Rotation Recorder
  - More on the way!
  
These abilities and instruments will affect the way all of the players experience the environment of the game. 
There is room at the moment for a puzzle and external fighting format which will combine the characteristics of the instruments and characters with a level-based puzzle design. 
We want to use some simple controllers for the players to use and some set of shared resources which may include a number of uses for the instruments per level.
Our initial goals for the project include 5 multiplayer levels, one Boss level, and one for funzies bonus level. 
Space Bears OUT!
