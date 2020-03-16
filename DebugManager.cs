using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is used to debug on the oculus quest when running application.
/// </summary>
public class DebugManager : MonoBehaviour
{
    //public GameObject rightHand;
    public CapsuleCollider playerController;
    public Transform cameraAnchor;
    public Text debugLog1;
    public Text debugLog2;
    public Text debugLog3;
    public Text debugLog4;
    public Text debugLog5;
    public Text debugLog6;
    //private Vector3 guardianSize;

    // Start is called before the first frame update
    void Start()
    {
        /*
        guardianSize = OVRManager.boundary.GetDimensions(OVRBoundary.BoundaryType.PlayArea);
        debugLog1.text = "Guardian Size: " + guardianSize;
        */
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        debugLog1.text = "Player: " + playerController.transform.position;
        debugLog2.text = "PlayerHeight: " + playerController.height;
        debugLog3.text = "Camera: " + cameraAnchor.position;
        /*
        debugLog1.text = "DotUp: " + Vector3.Dot(rightHand.transform.up, Vector3.down);
        debugLog2.text = "DotRight: " + Vector3.Dot(rightHand.transform.right, Vector3.left);
        debugLog3.text = "DotForward: " + Vector3.Dot(rightHand.transform.forward, Vector3.back);
        debugLog4.text = "Transform Up: " + rightHand.transform.up.y;
        debugLog5.text = "Transform Right: " + rightHand.transform.right.x;
        debugLog6.text = "Transform Forward: " + rightHand.transform.forward.z;
        */
    }
}
