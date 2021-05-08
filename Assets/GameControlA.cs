using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlA : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    //[SerializeField] private GameObject camara, canvasGeneral, reticula, canvasPuzzle, puzzle1, boton //cambio de Santiago
    //[SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    public static bool youWin;

    void Awake()
    {
        
        //winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        if ((pictures[0].rotation.z == 0 || pictures[0].rotation.z == 360) && (pictures[1].rotation.z == 0 || pictures[1].rotation.z == 360) && (pictures[2].rotation.z == 0 || pictures[2].rotation.z == 360) && (pictures[3].rotation.z == 0 || pictures[3].rotation.z == 360))
        {
            
            youWin = true;
           // boton.SetActive(false);
            // winText.SetActive(true);
            //mouseLocking.m_MouseLook.SetCursorLock(true);
            //mouseLocking.m_WalkSpeed = 5;
            //Destroy(camara);
            //StartCoroutine(ApagarPuzzle());

        }

    }
    /*IEnumerator ApagarPuzzle()
    {
        yield return new WaitForSeconds(3);
        // winText.SetActive(false);
        canvasPuzzle.SetActive(false);
        canvasGeneral.SetActive(true);
        reticula.SetActive(true);
        Destroy(puzzle1);
    }
    */

}
