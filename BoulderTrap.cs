using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Activates boulder trap.
/// </summary>
public class BoulderTrap: MonoBehaviour
{
    public Rigidbody boulder;
    public Animator trap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            trap.enabled = true;
            boulder.isKinematic = false;
            trap.Play("TrapDoorAnimation");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(this);
        }
    }
}
