﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionHandler : MonoBehaviour
{
    private SwitchCircuit curInteractable = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Interactable")
        {
            curInteractable = other.gameObject.GetComponent<SwitchCircuit>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == curInteractable.gameObject)
        {
            curInteractable = null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (curInteractable)
            {
                curInteractable.Activate();
            }
        }
    }
}
