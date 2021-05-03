using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour 
{
	
	void Start () 
	{
		Invoke ("LoadGame",1);
	}

	void Update () 
	{
	
	}

	void LoadGame()
	{
		SceneManager.LoadScene (1);
	}
}
