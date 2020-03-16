using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public BoxCollider trap;

    public Material blue;
    public Material pink;
    public Material red;

    public Animator blueWire;
    public Animator blueLight;
    public Animator pinkWire;
    public Animator pinkLight1;
    public Animator pinkLight2;
    public Animator pinkLight3;
    public Animator redWire;
    public Animator redLight1;
    public Animator redLight2;

    private GameObject key;

    private void Start()
    {
        key = this.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (key.name) {
            case "BallKey":
                this.gameObject.GetComponent<MeshRenderer>().material = blue;
                Destroy(blueWire);
                Destroy(blueLight);
                GameManager.boulderSwitch = true;
                    break;
            case "LaserKey":
                this.gameObject.GetComponent<MeshRenderer>().material = pink;
                Destroy(pinkWire);
                Destroy(pinkLight1);
                Destroy(pinkLight2);
                Destroy(pinkLight3);
                GameManager.jumpZone = false;
                GameManager.laserSwitch = true;
                break;
            case "AxeKey":
                this.gameObject.GetComponent<MeshRenderer>().material = red;
                Destroy(redWire);
                Destroy(redLight1);
                Destroy(redLight2);
                GameManager.axeSwitch = true;
                break;
            default:
                break;
        }

    }
}
