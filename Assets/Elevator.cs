using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private Transform bottom, top;
    [SerializeField]
    private float speed;

    private Rigidbody rb;
    private Vector3 curTarget;

    private void Awake()
    {
        curTarget = bottom.position;
    }

    public void ToggleElevator()
    {
        if (Vector3.Distance(transform.position, curTarget) > 0.5f) return;
        if(curTarget == top.position)
        {
            curTarget = bottom.position;
            return;
        }
        curTarget = top.position;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, curTarget, speed/10);
    }

}
