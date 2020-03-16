using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves boulder towards player.
/// </summary>
public class RollBoulder : MonoBehaviour
{
    private float traction;
    private float maxSpeed = 0.5f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == 16)
        {
            if (traction < maxSpeed)
            {
                traction += 0.01f;
            }
            else
            {
                traction = maxSpeed;
            }
            
            this.GetComponent<Rigidbody>().AddForce(Vector3.back * traction);
            
        }
    }
}
