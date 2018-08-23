using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour {

    private bool teleportEnabled;
    private bool firstClick;
    private float firstClickTime;
    private float doubleClickTimeLimit = 0.5f;
    public VRTeleporter teleporter;
    private void Start()
    {
        //teleportEnabled = false;
        //firstClick = false;
        //firstClickTime = 0f;
        teleporter.ToggleDisplay(false);
    }
    public void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            teleporter.ToggleDisplay(true);
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
        {
            teleporter.ToggleDisplay(true);
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryThumbstick))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickUp))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
        }
        //UpdateTeleportEnabled();
        //if(teleportEnabled)
        //{
        //    teleporter.ToggleDisplay(true);
        //    if(OVRInput.Get(OVRInput.Button.SecondaryThumbstick, OVRInput.Controller.RTouch))
        //    { teleporter.Teleport(); }

        //}

    }

    //private void UpdateTeleportEnabled()
    //{
    //    if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
    //    { // The trigger is pressed.
    //        if (!firstClick)
    //        { // The first click is detected.
    //            firstClick = true;
    //            firstClickTime = Time.unscaledTime;
    //        }
    //        else
    //        { // The second click detected, so toggle teleport mode.
    //            firstClick = false;
    //            ToggleTeleportMode();
    //        }
    //    }

    //    if (Time.unscaledTime - firstClickTime > doubleClickTimeLimit)
    //    { // Time for the double click has run out.
    //        firstClick = false;
    //    }
    //}

    //private void ToggleTeleportMode()
    //{
    //    teleportEnabled = !teleportEnabled;
        
    //    if (!teleportEnabled)
    //    {
    //        teleporter.ToggleDisplay(false);
    //    }
    //}
}
