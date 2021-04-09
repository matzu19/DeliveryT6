using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : MonoBehaviour, IAction
{
    [SerializeField]
    private int n;
    public bool stream;
    public bool win;
    [SerializeField]
    AudioSource activateSound;
    

    void Start()
    {
        activateSound = gameObject.GetComponent<AudioSource>();
    }
    public void Activate()
    {
        if (stream)
        {
            activateSound.Play();
            this.transform.Rotate(0f, 0f, -80f);
            win = true;
        }
        
        Debug.Log("el estado de la corriente es " + stream);
    }
}
