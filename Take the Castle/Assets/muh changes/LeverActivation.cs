using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class TriggerInformation {
    public string name;
    public string description;
}



public class LeverActivation : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    TriggerInformation TriggerOne;
        
    // Start is called before the first frame update
    void Start()
    {
        TriggerOne = new TriggerInformation();
        TriggerOne.name = "Sunflower";
        TriggerOne.description = "if i had a clue.....";
    }
    // uhhh this is supposed to do the collider thing?
        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("owaowauru");
            if (other.CompareTag("Player"))
            {
                triggerActive = true;
                
            }
        }
 
        public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = false;
                Debug.Log("exit");
            }
        }
    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
            {
                LeverTriggered();
            }
        
    }

    void LeverTriggered()
    {
        // cry? and add smth here that counts how many flowers are collected.. variable attached to player?
        // popup box that announces to player they collected the thingy
        Debug.Log(string.Format("You have collected the rare {0}", TriggerOne.name) );
        // this.transform.setActive(false);
        // how the actual f*ck do i make it disappear istg im gonna quit
        //if(col.gameObject.layer == 8 && isVisible)
        //{
        //col.gameObject.renderer.enabled = false;
        //isVisible = false;
        //}
    }
}


