using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] public class Trigger {
    public string name;
    public string description;
}


public class OpenBox : MonoBehaviour
{
    public CanExitLabyrinth test;

    [SerializeField] private bool triggerActive = false;
    Trigger TriggerOne;

    // Start is called before the first frame update
    void Start()
    {
        TriggerOne = new Trigger();
        TriggerOne.name = "chestOne";
        TriggerOne.description = "i dont really need this variable but oh well";

        test = GameObject.Find("Player").GetComponent<CanExitLabyrinth>();

    }
        public void OnTriggerEnter(Collider other)
        {
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
            }
        }

    // Update is called once per frame
    void Update()
    {

        if (triggerActive && Input.GetKeyDown(KeyCode.G))
            {
                LeverTriggered();
            }
    }

    void LeverTriggered()
    {
        // popup that tells player they got the thing? or i can roll with the box idrc
        transform.rotation = Quaternion.Euler(0, 0, 0);
        //chestOne = True;
        test.Collected.chestOne = true;
        test.chestOne = false;
    }
}
