using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// WORK IN PROGRESS.
/// </summary>
public class PlayerManager : MonoBehaviour
{

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public Material activeMat;
    public Material deactiveMat;

    private float health = 3f;

    private void checkHealth()
    {
        switch (health) {
            case 0:
                heart1.GetComponent<Image>().color = Color.red;
                break;
            case 1:
                heart2.GetComponent<Image>().color = Color.red;
                break;
            case 2:
                heart3.GetComponent<Image>().color = Color.red;
                break;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 15)
        {
            if (other.gameObject.name == "FrontAxe" || other.gameObject.name == "BackAxe")
            {
                health--;
                checkHealth();
            }
            else if (other.gameObject.name == "Ball") {
                health--;
                checkHealth();
            }
            else if (other.gameObject.name == "HighLaser" || other.gameObject.name == "LowLaser") {
                health--;
                checkHealth();
            }
        }
    }

}
