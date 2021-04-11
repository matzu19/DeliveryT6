using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rompecabezas : MonoBehaviour
{
    [SerializeField] private GameObject PressE, reticula, canvasPuzzle, canvasGeneral, camara;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    [SerializeField] private Collider bCollider;
    private bool puzzleActivo;
    private void FixedUpdate()
    {
        if (puzzleActivo)
        {
            PressE.SetActive(true);
            if (Input.GetMouseButtonDown(0) && PressE.activeInHierarchy)
            {
                PuzzleActivated();
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
        return puzzleActivo = false;
    }
    public void PuzzleActivated()
    {
        bCollider.enabled = !bCollider.enabled;
        canvasPuzzle.SetActive(true);
        canvasGeneral.SetActive(false);
        camara.SetActive(true);
        mouseLocking.m_MouseLook.SetCursorLock(false);
        mouseLocking.m_WalkSpeed = 0;
        PressE.SetActive(false);
        reticula.SetActive(false);
    }
    public void PuzzleDesactivated()
    {
        bCollider.enabled = true;
        canvasPuzzle.SetActive(false);
        canvasGeneral.SetActive(true);
        reticula.SetActive(true);
        camara.SetActive(false);
        mouseLocking.m_MouseLook.SetCursorLock(true);
        mouseLocking.m_WalkSpeed = 5;
    }
}
