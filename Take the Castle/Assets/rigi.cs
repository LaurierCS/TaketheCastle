using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour
{
      
    private bool left;
    public Transform[] pointArr;
    private bool didRotate;
    private int count;
    private bool didMove;
    private Vector3 p;

    
    // Start is called before the first frame update
    void Start()
    {   
        didRotate = false; 
        count = 0;
        didMove = false;
        p = transform.position;
        // float targetAngle = Mathf.Atan2(pointArr[count].position.x, pointArr[count].position.z);
        // transform.Rotate(0f, targetAngle, 0f);

        // transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 0);
        // count = count +1;
        
    }

    // Update is called once per frame
    void Update()
    {       
        
        var lookPos = pointArr[count].position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        if (!didRotate){  
            

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 3);
        }

        if (transform.rotation == rotation){
            didRotate = true;
        }
        pointArr[count].position = new Vector3(pointArr[count].position.x, p.y, pointArr[count].position.z);

        
        transform.position = Vector3.MoveTowards(transform.position, pointArr[count].position, 3 * Time.deltaTime);
        if (transform.position== pointArr[count].position){
             count= (count +1) % pointArr.Length;
             didRotate = false;
        }

        // }
        // if (!didMove){
        // transform.Translate(0f,0f,4f*Time.deltaTime);
        // }

        // else{
        //     didRotate = false
        //     count+=1
        // }

        // float targetAngle = Mathf.Atan2(pointArr[0].position.x, pointArr[0].position.z) * Mathf.Rad2Deg;
        // transform.LookAt(pointArr[0]);

        // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0.5f, 0f), 1);
        // // 
        // Debug.Log(targetAngle);
        
        // if (transform.rotation.y != targetAngle && transform.rotation.y != 360 - targetAngle){
        //     transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

        // }
        // if (transform.position.x == pointArr[count].position.x && transform.position.z == pointArr[count].position.y){
        //     transform.rotation = Quaternion.RotateTowards(transform.rotation, pointArr[count].rotation, 0);
        //     count = (count + 1) % pointArr.Length;

        // }
        
       
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(2);
    }
}
