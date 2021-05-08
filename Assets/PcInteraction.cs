using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcInteraction : MonoBehaviour, IAction
{
    [SerializeField] private GameObject CanvasPuzzle, canvasGeneral, reticula, camara;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
 
    void Awake()
    {
        CanvasPuzzle.gameObject.SetActive(false);
    
    }

    public void Back()
    {
        CanvasPuzzle.gameObject.SetActive(false);
        camara.gameObject.SetActive(false);
        canvasGeneral.gameObject.SetActive(true);
        mouseLocking.m_MouseLook.SetCursorLock(true);
        reticula.SetActive(true);
        mouseLocking.m_WalkSpeed = 5;
    }
    public void Activate()
    {    
        mouseLocking.m_MouseLook.SetCursorLock(false);
        CanvasPuzzle.gameObject.SetActive(true);  
        canvasGeneral.gameObject.SetActive(false);  
        camara.gameObject.SetActive(true);  
        reticula.SetActive(false);
        mouseLocking.m_WalkSpeed = 0;

    }
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(2f);

    }
}
