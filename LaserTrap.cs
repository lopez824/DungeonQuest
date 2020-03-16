using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
     
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            GameManager.jumpZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }


}
