using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineOn : MonoBehaviour, IAction
{
    bool machineStream;
    AudioSource machineM;
    public AudioClip on, off,sound;
    int n;

    void Start()
    {
        machineStream = false;
        machineM = gameObject.GetComponent<AudioSource>();
    }
    public void Activate()
    {
        machineStream = !machineStream;
        if (machineStream)
        {

            machineM.clip = on;
            machineM.loop = true;
            machineM.Play();
            StartCoroutine(waitTime()); 
           
        }
        else
        {

            machineM.clip = off;
            machineM.Play();
            machineM.loop = false;
        }
        
    }
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(8f);
        if(machineM.loop)
        machineM.clip = sound;
            machineM.Play();
    }


}
