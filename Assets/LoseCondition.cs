using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    //[SerializeField] private GameObject loseCanvas;

    public void perdiste()
    {
        SceneManager.LoadScene("cinematic Lose_");
        //loseCanvas.SetActive(true);
        //Time.timeScale = 0;
    }
    public void apagar()
    {
        //loseCanvas.SetActive(false);
    }
}
