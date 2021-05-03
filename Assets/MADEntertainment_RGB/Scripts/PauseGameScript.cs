using UnityEngine;
using System.Collections;

public class PauseGameScript : MonoBehaviour 
{
	bool IsPaused;
	public GameObject PausePanel;

	GameObject InputManager;
	RGBSwapScript RGB;

	void Start () 
	{
		InputManager = GameObject.FindGameObjectWithTag ("IM");
		RGB = InputManager.GetComponent<RGBSwapScript> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}

	public void Pause()
	{
		if (IsPaused) 
		{
			PausePanel.SetActive (false);
			Time.timeScale = 1;
			RGB.SetAllowClick(true);
		} 
		else 
		{
			PausePanel.SetActive (true);
			Time.timeScale = 0;
			RGB.SetAllowClick(false);
		}
		IsPaused = !IsPaused;
	}
}
