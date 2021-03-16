using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PastScene : MonoBehaviour
{
    private void OnEnable()
    {
        print("Pasó de escena");
        SceneManager.LoadScene("Level");
    }
}
