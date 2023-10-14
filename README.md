# VR-Labyrinth

Things to check:
- Is Sci-Fi map tall enough. If not, increase the height of whole Sci-Fi map to 1.1 or 1.2.
- Are tables tall enough?
- Does triggers work properly?
- If you find any flaws in the map, please contact me or if it's minor, fix it yourself.
- If you find spelling mistakes, please fix it.

How to add interactions:
- use Switch Trigger script for activate/deactivate.
- Sci-Fi map:
    - Add interaction to "Third room/Area T2"
- Dungeon map:
    Use "Area 1/Trigger (3)" to activate/deactivate interactions. I have already created a wall for shadow interaction in "Individual/Shadow wall" you can either modify it or remove it     and change to new one (if you remove it, don't forget to add it to add it to "Trigger (3)").
- If you have any problems with implementing, contact me.

Instructions for starting the game:
- When you start the game, all the object has to be initialised accurately. 
- Play has to be either "WASD Player" or "XR Origin" or "XR Origin" and "XR Device Simulator" depending on what you want to play with.
- If you are using "XR Origin":
   right controller (active)
      Crystal controller (inactive)
   left controller (inactive)

* Child objects that are not stated below must be active. (e.g. Fourth room/Area F4/Night sky is not mentioned so it must be active.)
* 'everything' means all the DIRECT child obejcts under specific parent object. (e.g. Area F4 is a direct child of Fourth room but Night sky is not)
* 'rest' means the rest of the DIRECT child objects under specific parent object.
  
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

Dungeon to Forest (inactive)
  everything (active)

Forest Map (active)
  Doesn't really matter since it is not made yet

  
  
  
    
  
    
    
    
