using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager gameManager;

    public static bool axeSwitch, boulderSwitch, laserSwitch; // Booleans to keep track of activated keys.
    public static bool jumpZone; // location on map where the player should jump.
    public static bool start; // used to start the timer on player's wrist.
    public static int levelIndex; // keeps track of level number.
    public static float playerHeight; // player's standing height.

    public static Vector3 CameraPos;
    public static Vector3[] spawnPoints; // spawn points used for transitioning levels.

    public CapsuleCollider player;

    private void Awake()
    {
        spawnPoints = new Vector3[3];
        spawnPoints[0] = new Vector3(0,0,-2);
        spawnPoints[1] = new Vector3(-4.5f, 0, 4.5f);
        spawnPoints[2] = new Vector3(0, 0, 5);

        // singleton, this is attached to the OVR Camera Rig such that there is only one instance of it.
        if (gameManager != null)
        {
            GameObject.Destroy(gameManager);
        }
        else
        {
            gameManager = this;
        }

        DontDestroyOnLoad(this);
    }
}
