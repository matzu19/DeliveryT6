using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineSound : MonoBehaviour, IAction
{
    bool machineEnergy;
    [SerializeField] AudioSource sound;
    [SerializeField] AudioClip _on, _in, _off;
  
    void start()
    {
        sound = gameObject.GetComponent<AudioSource>();
        machineEnergy = false;
    }
    public void Activate()
    {
        Debug.Log("--Activate---");
        machineEnergy = !machineEnergy;
        if (machineEnergy)
        {
            sound.clip = _on;
            sound.loop = true;
            sound.Play();
            StartCoroutine(waitTimeOn());
        }
        else
        {
            sound.clip = _off;
            sound.loop = false;
            sound.Play();
        }
    }

    IEnumerator waitTimeOn()
    {
       
        yield return new WaitForSeconds(8f);
        if (sound.clip == _on)
        {
            sound.clip = _in;
            sound.Play();
        }       
       
    }
}
