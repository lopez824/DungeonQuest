using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandZoneManager : MonoBehaviour
{
    // materials to indicate active triggers.
    public Material activeMat;
    public Material deActiveMat;

    // Start is called before the first frame update
    private void Start()
    {
        this.GetComponent<MeshRenderer>().material = deActiveMat;
    }

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = activeMat;
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = deActiveMat;
    }
}
