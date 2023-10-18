# VR-Labyrinth

## Project Brief 
This is a VR labyrinth game that utilises the concept of non-Euclidean geometry to allow users to explore infinite virtual space within finite play space physically instead of using controller inputs. Euclid's first postulate claims that any two points on a plane can be connected by a straight line; non-Euclidean geometry violates this rule. While traditional geometry asserts that any two points on a plane can be connected by a straight line, non-Euclidean geometry defies this norm. Our approach involves constructing pathways through rooms that depend on the user's perspective and position. We achieved this by placing transparent triggers that switches game object active/inactive when users collides. This project also includes additional interactions with virtual game objects. Since the controllers are not used for the movement, they are transformed into different object in VR and users are to interact with the object to complete the game. 
 
## How to Play
### Dependencies
* Meta Quest 2 headset and controllers.
* Table (50cm * 75cm * 100 cm)
* 4m * 4m play space

### Play space setup
* Decide a starting side.
* Place the table on the left corner and rotate the table so the 100cm edge is facing front. 
* Place a right controller on the table.
* The starting position is the right of the table.

### Unity setup
In the Unity project, all the game objects must be setup properly to play the game. The instructions below requires switching game object active and inactive. It can be switched by selecting a game object, then clicking a box on the left of the object name in the Inspector. The object is active if the box is ticked and inactive if the box is empty.

### VR headset setup
Install Oculus app on the computer. Connect Quest Link between the computer and the headset by a cable or Air Link (preferrably cable as Air Link is laggy).

#### Plugins
Open "Window/Project Manager" then click "Packages" and select "Unity Registry". Make sure "Oculus XR Plugin", "OpenXR Plugin", "XR Interaction Toolkit" and "XR Plugin Management" are installed. In "XR Interaction Toolkit", select "Samples" and import "Starter Assets" and "XR Device Simulator".

#### Player
There are three options for playing the game:
* VR headset and controllers: set "WASD Player" inactive, "XR Origin (XR Rig)" active, and "XR Device Simulator" inactive.
* VR simulation using WASD: set "WASD Player" inactive, "XR Origin (XR Rig)" active, and "XR Device Simulator" active.
* Keyboard WASD input: set "WASD Player" active, "XR Origin (XR Rig)" inactive, and "XR Device Simulator" inactive.

If using "XR Origin", select "XR Origin (XR Rig)/Camera Offset" then set "Left Controller" to inactive, "Right Controller" active, "Right Controller/CrystalBall" inactive, and "Right Controller/Red Ball" inactive.

#### Game Objects
Below is the instructions for which game objects should be active and inactive at the start of the game. Child objects that are not stated below must be active. (e.g. Fourth room/Area F4/Night sky is not mentioned so it must be active.) 'everything' means all the DIRECT child obejcts under specific parent object. (e.g. Area F4 is a direct child of Fourth room but Night sky is not)
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
All the files used in the game map are located in "Assets". Below are the particulary important folders.
* Assets: stores all the models of game objects. The assets are imported from the asset store.
* Scripts: stores the scripts for triggers and interactions.
* WASD Player: stores all relevent files for WASD player.

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

  
  
  
    
  
    
    
    
