using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FManson : MonoBehaviour
{
    public GameObject PressE;
    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && PressE.activeInHierarchy)
        {
            Debug.Log("Puzzle");
        }
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("FAMILYM");
        PressE.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        
        PressE.SetActive(false);
    }


}
