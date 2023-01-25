using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOffMap : MonoBehaviour
{
    private GameObject playerObj = null;
    private float originalPosition;
    private string currentSceneName;
 
     private void Start()
     {
         if (playerObj == null)
             playerObj = GameObject.Find("Player");

        originalPosition = playerObj.transform.position.y;
        currentSceneName = SceneManager.GetActiveScene().name;
     }
 
     private void Update()
     {
         if (playerObj.transform.position.y < originalPosition-16) {
            // load you died stuff here
            SceneManager.LoadScene(currentSceneName);
         }
     }
}
