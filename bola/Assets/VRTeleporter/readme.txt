# Quick Start

## Setup
You can find 'Teleporter' Prefab on Prefabs folder.

1. Attach Teleporter prefab as a child of game object which representing VR Hand(or position where drawing path start).
2. Asign Body Transform property with game object which you want to teleport. (ex: Root of player game object)

## How to control VRTeleporter

**All you need to do :**

1. Get reference of VRTeleporter object.
2. Use two public method of VRTeleporter script.

(You can check SampleVRTeleporterController.cs in Sample folder)

### Public Methods

#### void ToggleDisplay(bool active)

- Active and display visual.
- Update Path Vertices.
- Check ground position

When `ToggleDisplay(true)` is called, VRTeleporter automatically update it's arc path.
You need to call `ToggleDisplay(true)` in Update Method for re-calcuating path on every frame.

`ToggleDisplay(false)` will turn off renderer and stop detecting ground position.

#### void Teleport()

- Teleport bodyTransform to detected ground position.

Use this when player release input button.
(ex: Call Teleport method when Input.GetMouseButtonUp(0) is true)

## Example of how to control VRTeleporter

~~~
    public VRTeleporter teleporter;
    
    void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            teleporter.ToggleDisplay(true);
        }

        if(Input.GetMouseButtonUp(0))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
        }
    }
~~~

# Properties of VRTeleporter
- Position Marker : Game object used as ground position marker
- Body Transform : Game object which will be teleported
- Exclude Layers : Layers which you don't want to check
- Angle : Take-off angle of arc start position
- Strength : Factor for how far arc gonna go


# Sample
You can find quick sample on Sample Scene.

- Sample Scene use FPSController of Unity Standard Assets::Characters.
    - You need to import Character from [Assets] > [Import Package] > [Characters], to run sample scene.
- Standard Assets is not neccessary for actual use!!


There is FPSController game object in the Sample scene.
You can find Teleporter and Teleporter Controller gameObjects from FPSController's child objects.

- Leftclick-hold will show tha path.
- Leftclick-up will instantlty teleport player to target position.


# ETC
VRTeleprter script is accessible, you can change whatever you want.