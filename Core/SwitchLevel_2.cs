using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel_2 : MonoBehaviour
{
    [SerializeField] public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        print("Trigger Entered");
        if(other.tag == "Player") {
            print("Switching Scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
