using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    private Vector3 tempPos; // temporary position used for aligning finger tips properly.

    // finger tip offsets.
    private float palmXOffSet = 0.07f;
    private float palmYOffSet = 0.035f;
    private float thumbOffSet = 0.02f;

    // GameObjects to trigger finger events.
    public Transform rightPalmZone;
    public Transform rightThumbZone;
    public Transform rightIndexZone;
    public Transform rightMiddleZone;
    public Transform rightPinkyZone;
    public GameObject leftIndexFinger;

    // GameObjects to track finger tip position.
    public Transform rightThumb;
    public Transform rightIndexFinger;
    public Transform rightMiddleFinger;
    public Transform rightPinkyFinger;

    public GameObject leftHand;
    public OVRSkeleton rightHand;

    // Start is called before the first frame update
    private void Start()
    {
        SetFingerZones();
        SetFingerTips();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetFingerTips();
    }

    /// <summary>
    /// Places primitve gameObjects at the tip of your fingers.
    /// </summary>
    private void SetFingerTips()
    {
        rightThumb.position = rightHand.Bones[19].Transform.parent.transform.position;
        rightThumb.rotation = rightHand.Bones[19].Transform.parent.transform.rotation;
        rightIndexFinger.position = rightHand.Bones[20].Transform.parent.transform.position;
        rightIndexFinger.rotation = rightHand.Bones[20].Transform.parent.transform.rotation;
        rightMiddleFinger.position = rightHand.Bones[21].Transform.parent.transform.position;
        rightMiddleFinger.rotation = rightHand.Bones[21].Transform.parent.transform.rotation;
        rightPinkyFinger.position = rightHand.Bones[23].Transform.parent.transform.position;
        rightPinkyFinger.rotation = rightHand.Bones[23].Transform.parent.transform.rotation;
    }

    /// <summary>
    /// Positions trigger zones for finger tips.
    /// </summary>
    private void SetFingerZones()
    {
        rightPalmZone.position = rightHand.Bones[0].Transform.parent.transform.position;
        tempPos = rightPalmZone.position;
        tempPos.x = rightPalmZone.position.x - palmXOffSet;
        tempPos.y = rightPalmZone.position.y - palmYOffSet;
        rightPalmZone.position = tempPos;

        rightThumbZone.position = rightHand.Bones[19].Transform.parent.transform.position;
        rightThumbZone.position = Vector3.Reflect(rightThumbZone.position, Vector3.right);
        tempPos = rightThumbZone.position;
        tempPos.z = rightThumbZone.position.z * -1; // needed to reflect each finger tip about the z axis for some reason. 
        tempPos.y = tempPos.y + thumbOffSet;
        rightThumbZone.position = tempPos;

        rightIndexZone.position = rightHand.Bones[20].Transform.parent.transform.position;
        rightIndexZone.position = Vector3.Reflect(rightIndexZone.position, Vector3.right);
        tempPos = rightIndexZone.position;
        tempPos.z = rightIndexZone.position.z * -1;
        rightIndexZone.position = tempPos;

        rightMiddleZone.position = rightHand.Bones[21].Transform.parent.transform.position;
        rightMiddleZone.position = Vector3.Reflect(rightMiddleZone.position, Vector3.right);
        tempPos = rightMiddleZone.position;
        tempPos.z = rightMiddleZone.position.z * -1;
        rightMiddleZone.position = tempPos;

        rightPinkyZone.position = rightHand.Bones[23].Transform.parent.transform.position;
        rightPinkyZone.position = Vector3.Reflect(rightPinkyZone.position, Vector3.right);
        tempPos = rightPinkyZone.position;
        tempPos.z = rightPinkyZone.position.z * -1;
        rightPinkyZone.position = tempPos;
    }
}
