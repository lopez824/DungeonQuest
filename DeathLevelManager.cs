using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathLevelManager : MonoBehaviour
{
    private Vector3 portalPos;
    private GameObject Camera;
    private CapsuleCollider player;
    public Animator lightAnim;
    public Text debug1;
    public Text debug2;
    public Text debug3;
    public Text debug4;
    public Text debug5;
    public Text debug6;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("OVRCameraRig");
        player = Camera.GetComponent<GameManager>().player;

        Camera.transform.position = GameManager.CameraPos;
        lightAnim.Play("LightAnimation");
        switch (GameManager.levelIndex)
        {
            case 0:
                portalPos = GameManager.spawnPoints[0];
                portalPos.y = GameManager.playerHeight;
                transform.position = portalPos;
                break;
            case 1:
                portalPos = GameManager.spawnPoints[1];
                portalPos.y = GameManager.playerHeight;
                transform.position = portalPos;

                break;
            case 2:
                portalPos = GameManager.spawnPoints[2];
                portalPos.y = GameManager.playerHeight;
                transform.position = portalPos;
                break;
            default:
                break;
        }
    }

    private void FixedUpdate()
    {
        debug1.text = "Level Index: " + GameManager.levelIndex;
        debug2.text = "SpawnPoint2: " + GameManager.spawnPoints[1];
        debug3.text = "Level 1 Camera: " + GameManager.CameraPos;
        debug4.text = "Portal: " + transform.position;
        debug5.text = "Player: " + player.transform.position;
        debug6.text = "Player Height: " + GameManager.playerHeight;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            switch (GameManager.levelIndex)
            {
                case 0:
                    SceneManager.LoadScene("Level1");
                    break;
                case 1:
                    SceneManager.LoadScene("Level2");
                    break;
                case 2:
                    SceneManager.LoadScene("Level3");
                    break;
                default:
                    break;
            }
        }
    }
}
