using UnityEngine;
using System.Collections;

public class Playsound : MonoBehaviour 
{
	[SerializeField] private AudioSource normalClick, correctClick;
	public void Clicky()
	{
		normalClick.Play();
	}
	public void ClickyDone()
	{
		correctClick.Play();
	}

}
