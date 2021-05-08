using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    [SerializeField] private GameControlA won;
    [SerializeField] private GameObject door;

    private void Update()
    {
        for (int i = 0; i < 1; i++)
        {
            if (won.IsWin() == true)
            {
                this.door.transform.Rotate(-90f, 0f, 0f);
            }
            i++;
        }
    }
}
