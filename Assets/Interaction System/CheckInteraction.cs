﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInteraction : MonoBehaviour
{   
    [SerializeField]
    private GameObject rayOrigin;
    [SerializeField] public Material highlightMaterial, defaultMaterial;
    [SerializeField] GameObject PressE;
    public Transform selection;

    private bool canInteract;

    private InteractionReceiver currentReceiver;


    private void Start()
    {

    }

    void Update()
    {
        if (currentReceiver != null)
        {
            var selectionMaterial = selection.GetComponent<Renderer>();
            selectionMaterial.material = defaultMaterial;
            canInteract = false;
            PressE.SetActive(false);
        }

        currentReceiver = null;

        var ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1.5f))
        {
            selection = hit.transform;
            currentReceiver = selection.gameObject.GetComponent<InteractionReceiver>();
            defaultMaterial = selection.GetComponent<Renderer>().material;
        }

        if (currentReceiver != null)
        {
            var selectionMaterial = selection.GetComponent<Renderer>();
            selectionMaterial.material = highlightMaterial;
            canInteract = true;
            PressE.SetActive(true);
        }

        if (canInteract)
        {
            PressE.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                currentReceiver.Activate();
            }
            
        }

    }

}
