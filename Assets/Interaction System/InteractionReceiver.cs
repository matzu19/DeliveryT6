using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class InteractionReceiver : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsWithActions;


    public void Activate()
    {
        try
        {

            foreach (GameObject o in objectsWithActions)
            {
                o.GetComponent<IAction>().Activate();
            }
        }
        catch (NullReferenceException)
        {

        }
    }
}
