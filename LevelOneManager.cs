using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneManager : MonoBehaviour
{
    private IEnumerator laserRoutine;
    private IEnumerator axeRoutine;

    private float laserDelay = 3.0f;
    private float axeDelay = 0.5f;

    public Animator LowLaser;
    public Animator FrontAxe;

    // Setting up level one.
    private void Start()
    {
        GameManager.levelIndex = 0;
        GameManager.axeSwitch = false;
        GameManager.boulderSwitch = false;
        GameManager.laserSwitch = false;
        GameManager.jumpZone = false;
        GameManager.start = true;

        laserRoutine = delayLaserAnim();
        StartCoroutine(laserRoutine);

        axeRoutine = delayAxeAnim();
        StartCoroutine(axeRoutine);
    }

    /// <summary>
    /// Delays animation.
    /// </summary>
    IEnumerator delayLaserAnim()
    {
        yield return new WaitForSeconds(laserDelay);
        LowLaser.enabled = true;
        LowLaser.Play("LowLaserAnimation");
    }

    /// <summary>
    /// Delays animation.
    /// </summary>
    IEnumerator delayAxeAnim()
    {
        yield return new WaitForSeconds(axeDelay);
        FrontAxe.enabled = true;
        FrontAxe.Play("FrontAxeAnimation");
    }
}
