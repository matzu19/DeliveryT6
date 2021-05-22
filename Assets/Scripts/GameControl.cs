using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField] private GameObject  camara, canvasGeneral, reticula, canvasPuzzle, puzzle1, boton, Nota, rompekbzas; //cambio de Santiago
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    public static bool youWin;
    [SerializeField] Sprite sprite1,sprite2;

    void Awake()
    {
        rompekbzas.GetComponent<SpriteRenderer>().sprite = sprite1;
        Nota.SetActive(false);
        //winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        if (pictures[0].rotation.z == 0 && pictures[1].rotation.z == 0 && pictures[2].rotation.z == 0 && pictures[3].rotation.z == 0 && pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 && pictures[6].rotation.z == 0 && pictures[7].rotation.z == 0 && pictures[8].rotation.z == 0 && pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 && pictures[11].rotation.z == 0 && pictures[12].rotation.z == 0 && pictures[13].rotation.z == 0 && pictures[14].rotation.z == 0 &&
            pictures[15].rotation.z == 0)     
        {
            rompekbzas.tag = "Untagged";
            Nota.SetActive(true);
            rompekbzas.GetComponent<SpriteRenderer>().sprite = sprite2;
            youWin = true;
            boton.SetActive(false);
           // winText.SetActive(true);
            mouseLocking.m_MouseLook.SetCursorLock(true);
            mouseLocking.m_WalkSpeed = 5;
            camara.SetActive(false);
            StartCoroutine(ApagarPuzzle());
        }

    }
    IEnumerator ApagarPuzzle()
    {
        yield return new WaitForSeconds(3);
       // winText.SetActive(false);
        canvasPuzzle.SetActive(false);
        canvasGeneral.SetActive(true);
        reticula.SetActive(true);
        Destroy(puzzle1);
    }
}
