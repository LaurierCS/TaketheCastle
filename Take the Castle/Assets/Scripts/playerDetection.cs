using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerDetection : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent enemy;
    public float viewAngle = 90;
    public int viewRange = 30;
    Vector3 me = new Vector3(0, 0, 0);
    Vector3 you = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        me = transform.position;
        me.y += 1;
        you = target.position;
        you.y += 1;
        Vector3 toTarget = you - me;
        if (Vector3.Angle(transform.forward, toTarget) <= viewAngle)
        {
            if (Physics.Raycast(me, toTarget, out RaycastHit hitInfo, viewRange))
            {
                Debug.DrawRay(me, toTarget, Color.green);
                if (hitInfo.transform.root == target)
                {
                    enemy.SetDestination(target.position);
                }
            }
        }
    }
}