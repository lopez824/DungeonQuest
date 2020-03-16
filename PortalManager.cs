using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// WORK IN PROGRESS.
/// </summary>
public class PortalManager : MonoBehaviour
{
    public Material activeMat;
    public Transform Camera;

    IEnumerator LoadDeathLevel()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("DeathLevel", LoadSceneMode.Single);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (GameManager.levelIndex)
        {
            case 0:
                if (other.gameObject.layer == 9 && GameManager.axeSwitch == true && GameManager.boulderSwitch == true && GameManager.laserSwitch == true)
                {
                    GameManager.levelIndex++;
                    GameManager.CameraPos = Camera.position;
                    this.GetComponent<MeshRenderer>().material = activeMat;
                    //StartCoroutine(LoadDeathLevel());
                }
                break;
            case 1:
                if (other.gameObject.layer == 9)
                {
                    GameManager.levelIndex++;
                    GameManager.CameraPos = Camera.position;

                    StartCoroutine(LoadDeathLevel());
                }
                break;
            case 2:
                if (other.gameObject.layer == 9)
                {

                }
                break;
            default:
                break;
        }
    }
}
