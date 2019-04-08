using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [SerializeField]
    private Transform openPos, closedPos;
    [SerializeField]
    private float speed;

    private Vector3 curTarget;

    private void Awake()
    {
        curTarget = closedPos.position;
    }

    public void ToggleDoor()
    {
        if (Vector3.Distance(transform.position, curTarget) > 0.5f) return;
        if (curTarget == openPos.position)
        {
            curTarget = closedPos.position;
            return;
        }
        curTarget = openPos.position;
    }

    public void CloseDoor()
    {
        curTarget = closedPos.position;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, curTarget, speed / 10);
    }
}
