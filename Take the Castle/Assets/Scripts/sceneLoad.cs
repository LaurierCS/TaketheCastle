using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoad : MonoBehaviour
{
    // public string sceneName;

    // void OnTriggerEnter(Collider other) {
    //     if (other.CompareTag("Player")){
    //         SceneManager.LoadScene(sceneName);
    //     }
    // }
    [SerializeField] private string nextLevel;
    [SerializeField] private GameObject uiElement;
    
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(true);
            if (Input.GetKeyDown(KeyCode.P))
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }

    void OnTriggerExit(Collider other){

        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
        }
    }
}
