using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    public bool win;
    [SerializeField] private Gloves guantes;
    [SerializeField] GameObject canvaDamage;

    AudioSource sound;
    [SerializeField] AudioClip leverActivate, problem;
    
    void Start()
    {
        sound = gameObject.GetComponent<AudioSource>();
        canvaDamage.gameObject.SetActive(false);
    }

    
    void condicion1()
    {

    }
    void condicion2()
    {

    }
    void condicion3()
    {

    }


    public void Activate()
    {
        Debug.Log("--Activate lever ");
        if (stream /*&& guantes.guantesPuesto()*/)
        {
            sound.clip = leverActivate;
            sound.Play();
            this.transform.Rotate(0f, 0f, -80f);
            win = true;

        }
        else
        {
            canvaDamage.SetActive(true);
            sound.clip = problem;
            sound.Play();
            StartCoroutine(waitTimeOn());
            
        }
        
        Debug.Log("el estado de la corriente es " + stream);
    }

    IEnumerator waitTimeOn()
    {
        yield return new WaitForSeconds(1.3f);
        canvaDamage.SetActive(false);
    }
}
