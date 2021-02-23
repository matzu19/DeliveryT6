using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if (!GameControl.youWin)
            transform.Rotate(0f, 0f, 90f);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
