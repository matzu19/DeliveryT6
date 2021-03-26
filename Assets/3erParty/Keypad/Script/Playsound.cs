using UnityEngine;
using System.Collections;

public class Playsound : MonoBehaviour 
{
	[SerializeField] private AudioSource normalClick, correctClick, MistakeClick;
	public void Clicky()
	{
		normalClick.Play();
	}
	public void ClickyDone()
	{
		correctClick.Play();
	}
	public void ClickyFix()
	{
		MistakeClick.Play();
	}

}
