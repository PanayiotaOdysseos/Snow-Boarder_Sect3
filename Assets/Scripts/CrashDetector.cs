using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground") {

            Invoke("ReloadSceneCrash", delayTime);
            //Debug.Log("You crashed");

        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

