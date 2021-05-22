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
    [SerializeField] private GameObject door;
    bool gano;

    void Awake()
    {
        gano = false;
        youWin = false;
    }
    void Update()
    {
        if ((pictures[0].rotation.z == 0 || pictures[0].rotation.z == 360) && (pictures[1].rotation.z == 0 || pictures[1].rotation.z == 360) && (pictures[2].rotation.z == 0 || pictures[2].rotation.z == 360) && (pictures[3].rotation.z == 0 || pictures[3].rotation.z == 360))
        {
            print("se debe abrir puerta");

            
            youWin = true;
            gano = false;
            //door.GetComponent<Animation>().Play();
            door.GetComponent<Animator>().enabled=true;
            //Destroy(door);
            if (gano == false)
            {
                GetComponent<AudioSource>().Play();
                gano = true;
                print("debe reproducir sonido puerta");
            }
        }
    }
    public bool IsWin()
    {
        return youWin;
    }
}
