# VR-Labyrinth

## Project Brief

This is a VR labyrinth game that utilizes the concept of non-Euclidean geometry to allow users to explore infinite virtual space within finite physical play space without using controller inputs. Euclid's first postulate claims that any two points on a plane can be connected by a straight line; non-Euclidean geometry violates this rule. While traditional geometry asserts that any two points on a plane can be connected by a straight line, non-Euclidean geometry defies this norm. Our approach involves constructing pathways through rooms that depend on the user's perspective and position. We achieved this by placing transparent triggers that switch game objects between active and inactive when users collide with them. This project also includes additional interactions with virtual game objects. Since the controllers are not used for movement, they are transformed into different objects in VR, and users interact with these objects to complete the game.

## How to Play

### Dependencies

* Meta Quest 2 headset and controllers.
* Table (50cm * 75cm * 100cm)
* 4m * 4m play space

### Play space setup

* Decide on a starting side.
* Place the table in the left corner and rotate it so the 100cm edge is facing the front.
* Place a right controller on the table.
* The starting position is to the right of the table.

### Unity setup

Open this entire folder as a new project in Unity Hub. In the Unity project, all game objects must be set up properly to play the game. The instructions below require switching game objects between active and inactive states. This can be done by selecting a game object and clicking the checkbox on the left of the object's name in the Inspector. The object is active if the box is checked and inactive if the box is empty.

### VR headset setup

Install the Oculus app on the computer. Connect the Quest Link between the computer and the headset using a cable or Air Link (preferably a cable, as Air Link may introduce lag).

#### Plugins

Open "Window/Project Manager" then click "Packages" and select "Unity Registry." Make sure "Oculus XR Plugin," "OpenXR Plugin," "XR Interaction Toolkit," and "XR Plugin Management" are installed. In "XR Interaction Toolkit," select "Samples" and import "Starter Assets" and "XR Device Simulator."

#### Player

There are two options for playing the game:

* VR headset and controllers: Set "XR Origin (XR Rig)" to active, and "XR Device Simulator" to inactive.
* VR simulation using WASD: Set "XR Origin (XR Rig)" to active, and "XR Device Simulator" to active.

If using "XR Origin," select "XR Origin (XR Rig)/Camera Offset" and set "Left Controller" to inactive, "Right Controller" to active, "Right Controller/CrystalBall" to inactive, and "Right Controller/Cylinderhand" to inactive. 

#### Game Objects

Below are the instructions for which game objects should be active and inactive at the start of the game. Child objects that are not mentioned must be active. For example, "Fourth room/Area F4/Night sky" is not mentioned, so it must be active. "Everything" means all the direct child objects under a specific parent object.


<pre>
SciFi Map (active)
  Roof (active)
  Origin (active)
  Fourth room (active)
    everything (inactive)
  Third room (active) 
    everything (inactive) 
  Second room (active) 
    everything (inactive) 
  First room (active) 
    everything (inactive) 
  
SciFi to Dungeon (inactive) 
  everything (active)
  
SciFi to Dungeon (1) (inactive) 
  everything (active) 
  
Dungeon Map (active) 
  Defualt (active) 
    Floor (active)
      everything (inactive)
    Wall (active) 
      everything (inactive)
    Roof (active)
      everything (inactive)
  Individual (active)
    everything (inactive)
  Origin (active)
    everything (inactive)
  Area 1 (inactive)
</pre>

## File Locations

All the files used in the game map are located in "Assets." Below are the particularly important folders.

* Assets: Stores all the models of game objects. The assets are imported from the asset store.
* Scripts: Stores the scripts for triggers and interactions.
* WASD Player: Stores all relevant files for the WASD player.

## Authors

Chan Zean Yang <br />
Ku Zheng Yan <br />
Lo Wen An <br />
Ching Yaw Yu <br />
Conyll Forbes <br />
Reona Nakagawa <br />

## Acknowldgement 

* [SebLague](https://github.com/SebLague/Portals)
* [karboosx](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913#description)
* [Ryan Zehm](https://assetstore.unity.com/packages/3d/environments/landscapes/stylized-earth-94673)
* [JustCreate](https://assetstore.unity.com/packages/3d/environments/dungeons/low-poly-dungeons-lite-177937#publisher)

  
  
  
    
  
    
    
    
