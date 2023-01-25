using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class playerDetection : MonoBehaviour
{
    public Transform target;
    public float viewAngle = 90;
    public int viewRange = 30;
    public int catchRange = 1;
    Vector3 me = new Vector3(0, 0, 0);
    Vector3 you = new Vector3(0, 0, 0);
    public bool chase = false;
    string currentSceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        me = transform.position;
        me.y += 1;
        you = target.position;
        you.y += 1;
        Vector3 toTarget = you - me;
        var lookPos = you - me;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        if (Vector3.Angle(transform.forward, toTarget) <= viewAngle)
        {
            if (Physics.Raycast(me, toTarget, out RaycastHit hitInfo, viewRange))
            {
                if (hitInfo.transform.root == target)
                {
                    Debug.DrawRay(me, toTarget, Color.green);
                    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5);
                    transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 3);
                    chase = true;
                }
                else
                {
                    chase = false;
                }
            }
            else
                {
                    chase = false;
                }
        }
        else
                {
                    chase = false;
                }
        if (Physics.Raycast(me, toTarget, out RaycastHit hit, catchRange))
        {
            if (hit.transform.root == target)
                {
                    SceneManager.LoadScene(currentSceneName);
                }
        }
    }
}