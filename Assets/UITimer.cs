using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITimer : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI timerMinutes;
	[SerializeField] private float timer;
	[SerializeField] private Color colorMid, ColorFinal;
    [SerializeField] private LoseCondition canvaLose;

    private void Awake()
    {
		canvaLose.apagar();
        timer = 300f;
    }
	void Update()
	{
		timer -= Time.deltaTime;
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer % 60F);
		int milliseconds = Mathf.FloorToInt((timer * 100F) % 100F);
		timerMinutes.text = minutes.ToString("00") + ":" + seconds.ToString("00");
		if (timer <= 200f && timer > 100f) timerMinutes.color = colorMid;
		else if (timer <= 60f && timer > 0f) timerMinutes.color = ColorFinal;
		if (timer <= 0)
		{
			canvaLose.perdiste();
		}
	}

}
