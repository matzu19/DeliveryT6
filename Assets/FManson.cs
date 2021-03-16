using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FManson : MonoBehaviour
{

 //   [SerializeField] private GameObject PressE, canvasPuzzle, camara; //HEad

    [SerializeField] private GameObject PressE, canvasPuzzle, canvasGeneral, reticula, camara; //Santiago
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    [SerializeField] private Collider bCollider;

    void Awake()
    {
        PressE.SetActive(false);
        canvasPuzzle.SetActive(false);
        bCollider = GetComponent<Collider>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && PressE.activeInHierarchy)
        {
            canvasPuzzle.SetActive(true);
            canvasGeneral.SetActive(false);
            reticula.SetActive(false);
            camara.SetActive(true);
            mouseLocking.m_MouseLook.SetCursorLock(false);
            PressE.SetActive(false);
            bCollider.enabled = !bCollider.enabled;
        }

    }
    public void IsInteractive()
    {
        PressE.SetActive(true); 
    }
    public void IsNotInteractive()
    {
        PressE.SetActive(false);
    }


}
