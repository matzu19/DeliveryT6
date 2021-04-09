﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcInteraction : MonoBehaviour, IAction
{
    [SerializeField] private GameObject CanvasPuzzle, reticula;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
 


    void Awake()
    {
        CanvasPuzzle.gameObject.SetActive(false);
    
    }

    public void Back()
    {
        CanvasPuzzle.gameObject.SetActive(false);
        mouseLocking.m_MouseLook.SetCursorLock(true);
        reticula.SetActive(true);
    }
    public void Activate()
    {    
        mouseLocking.m_MouseLook.SetCursorLock(false);
        CanvasPuzzle.gameObject.SetActive(true);  
           reticula.SetActive(false);

    }
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(2f);

    }
}