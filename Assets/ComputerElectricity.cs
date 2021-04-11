using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerElectricity : MonoBehaviour , IAction
{
    bool electricity;
    [SerializeField]
    private SwitchLever swithcOne, swithcTwo, swithcThree;
    [SerializeField]
    GameObject isOn, isOff;


    void Start()
    {
        electricity = false;
        isOn.gameObject.SetActive(false);
        isOff.gameObject.SetActive(false);
    }
  
        

    public void Activate()
    {
        electricity = !electricity;
        if (electricity)
        {
            swithcOne.stream = true;
            swithcTwo.stream = true;
            swithcThree.stream = true;         
            StartCoroutine(waitTimeOn());   
            Debug.Log("Pc Stream Activated");
        }
        else
        {
            swithcOne.stream = false;
            swithcTwo.stream = false;
            swithcThree.stream = false;         
            StartCoroutine(waitTimeOff());            
            Debug.Log("Pc Stream deactivated");

        }
    }

    IEnumerator waitTimeOn()
    {
        if(isOff.activeInHierarchy == true)
          isOff.gameObject.SetActive(false);
        
        isOn.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        isOn.gameObject.SetActive(false);
    }
    IEnumerator waitTimeOff()
    {
        if (isOn.activeInHierarchy == true)
            isOn.gameObject.SetActive(false);

        isOff.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        isOff.gameObject.SetActive(false);
    }
}
