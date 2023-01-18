using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour
{
    private bool left;
    // Start is called before the first frame update
    void Start()
    {
        left = true;
        
    }

    // Update is called once per frame
    void Update()
    {   
            transform.Translate(0f,0f,4f*Time.deltaTime);

       
        if (transform.position.z <= 8.5){
            transform.Rotate(0, 90, 0);
        }
        if(transform.position.z >= 17.3 ){
            transform.Rotate(0, 90, 0);

        }
       
    }
}
