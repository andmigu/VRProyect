using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public GameObject TeleportMarker;
    public Transform Player;
    public float RayLength = 50f;
    private bool teleportEnabled;
    //public AudioSource audioSource;
    public AudioClip clip;

    // Use this for initialization
    void Start()
    {
        TeleportMarker.SetActive(false);
        teleportEnabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {//push a button to activate(UpdateTeleportEnable)
     //handleTeleport
     //Teleport
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            ToggleTeleportMode();
        }
        if (teleportEnabled)
        { HandleTeleport(); }
    }

    

    private void ToggleTeleportMode()
    {
        teleportEnabled = !teleportEnabled;
        if(!teleportEnabled)
        {
            TeleportMarker.SetActive(false);
        }
    }

    private void HandleTeleport()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, RayLength))
        {
            if (hit.collider.tag == "Ground")
            {
                if (!TeleportMarker.activeSelf)
                {
                    TeleportMarker.SetActive(true);
                }
                TeleportMarker.transform.position = hit.point;

                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) // Teleport to the position.
                {
                    //clip.;
                    Vector3 markerPosition = TeleportMarker.transform.position;
                    Player.position = new Vector3(markerPosition.x, Player.position.y,
                        markerPosition.z);
                }
                else
                {
                    TeleportMarker.SetActive(false);
                }
            }
            else
            {
                TeleportMarker.SetActive(false);
            }
        }
    }

   
}


