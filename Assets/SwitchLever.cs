using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    public bool win;
    [SerializeField] private Gloves guantes;
    public GameObject screw;
    [SerializeField] GameObject canvaDamage,g_message;
    public Text message;

    AudioSource sound;
    [SerializeField] AudioClip leverActivate;
    [SerializeField] AudioClip[] problem = new AudioClip[3];
    
    void Start()
    {
        g_message = message.gameObject;
        g_message.SetActive(false);
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
        //Debug.Log("--Activate lever ");

       
        if(stream && guantes.guantesPuesto() && n == 2 && screw.gameObject.activeInHierarchy)
        {
            sound.clip = leverActivate;
            sound.Play();
            this.transform.Rotate(0f, 0f, -80f);
            win = true;
            message.text = ("Lever is active");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        else if (stream && guantes.guantesPuesto() && n != 2)
        {
            sound.clip = leverActivate;
            sound.Play();
            this.transform.Rotate(0f, 0f, -80f);
            win = true;
            message.text = ("Lever is active");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        else if (n == 2 && screw.gameObject.activeInHierarchy && guantes.guantesPuesto())
        {
            message.text = ("The machine has no energy");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        else if (n == 2 && guantes.guantesPuesto())
        {
            message.text = ("This lever has a missing screw");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        else if(stream)
        {
            canvaDamage.SetActive(true);
            ProblemPlay();
            sound.Play();
            StartCoroutine(waitTimeOn(canvaDamage));
            message.text = ("¡This stream could kill!");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
       
        else if (n==2)
        {
            message.text = ("This lever has a missing screw");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        else
        {
            message.text = ("The machine has no energy");
            g_message.SetActive(true);
            StartCoroutine(waitTimeOn(g_message));
        }
        
        Debug.Log("el estado de la corriente es " + stream);

    }

    IEnumerator waitTimeOn(GameObject g)
    {
        yield return new WaitForSeconds(3f);
        g.SetActive(false);
    }
    void ProblemPlay()
    {
        sound.clip = problem[Random.Range(0,problem.Length)];
    }
}
