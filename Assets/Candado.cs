using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candado : MonoBehaviour
{
    [SerializeField] private GameObject PressE, reticula, canvasPuzzle, canvasGeneral, camara;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    [SerializeField] private Collider bCollider;
    [SerializeField] private Image pickImg;
    [SerializeField] private float timeHeld = 0;
    private bool puzzleActivo;
    private void FixedUpdate()
    {
        if (this.puzzleActivo)
        {
            PressE.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                this.timeHeld += Time.deltaTime;
                pickImg.color = new Color(0f, this.timeHeld, 0f, 1f);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                this.timeHeld = 0;
                pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
            }

            if (this.timeHeld > 1f)
            {
                PuzzleActivated();
            }
        }
        else
        {
            this.timeHeld = 0;
            pickImg.color = new Color(0f, this.timeHeld, 0f, 0f);
        }
    }
    public bool ActivarPuzzle()
    {
        return puzzleActivo = true;
    }
    public bool DesactivarPuzzle()
    {
        return puzzleActivo = false;
    }
    public void PuzzleActivated()
    {
        this.puzzleActivo = false;
        bCollider.enabled = !bCollider.enabled;
        canvasPuzzle.SetActive(true);
        canvasGeneral.SetActive(false);
        camara.SetActive(true);
        mouseLocking.m_MouseLook.SetCursorLock(false);
        mouseLocking.m_WalkSpeed = 0;

    }
    public void PuzzleDesactivated()
    {
        bCollider.enabled = true;
        canvasPuzzle.SetActive(false);
        canvasGeneral.SetActive(true);
        camara.SetActive(false);
        mouseLocking.m_MouseLook.SetCursorLock(true);
        mouseLocking.m_WalkSpeed = 5;
    }

}
