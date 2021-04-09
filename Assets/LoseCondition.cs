using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    [SerializeField] private GameObject loseCanvas;

    public void perdiste()
    {
        loseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void apagar()
    {
        loseCanvas.SetActive(false);
    }
}
