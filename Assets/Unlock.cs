using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    [SerializeField] private GameObject  camara, canvasGeneral, reticula, canvasPuzzle, puzzle1; //cambio de Santiago
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;

    public void UnlockedPuzzle()
    {
        camara.SetActive(false);
        StartCoroutine(Unlocked());
    }
 IEnumerator Unlocked()
    {
        yield return new WaitForSeconds(0.5f);
        mouseLocking.m_MouseLook.SetCursorLock(true);
        mouseLocking.m_WalkSpeed = 5;
        canvasPuzzle.SetActive(false);
        canvasGeneral.SetActive(true);
        reticula.SetActive(true);
        Destroy(puzzle1);
    }
}
