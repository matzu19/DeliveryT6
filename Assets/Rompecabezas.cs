using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Rompecabezas : MonoBehaviour
{
    [SerializeField] private GameObject PressE, reticula, canvasPuzzle, canvasGeneral, camara; //Santiago
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    [SerializeField] private Collider bCollider;
    private bool puzzleActivo;
    private void Update()
    {
        if (puzzleActivo)
        {
            PressE.SetActive(true);
            reticula.SetActive(false);
            if(Input.GetKey(KeyCode.E) && PressE.activeInHierarchy)
            {
                canvasPuzzle.SetActive(true);
                canvasGeneral.SetActive(false);
                camara.SetActive(true);
                mouseLocking.m_MouseLook.SetCursorLock(false);
                mouseLocking.m_WalkSpeed = 0;
                PressE.SetActive(false);
                bCollider.enabled = !bCollider.enabled;
            }
        }

    }
    public bool ActivarPuzzle()
    {
        return puzzleActivo = true;
    }
    public bool DesactivarPuzzle()
    {
        PressE.SetActive(false);
        reticula.SetActive(true);
        return puzzleActivo = false;
    }
}
