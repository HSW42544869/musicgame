using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour 
{
	ScoreScript SS;
	GameObject GameManager;
	
	public Text ScoreText;
	int Score;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag ("GM");
		SS = GameManager.GetComponent<ScoreScript> ();

		SS.ResetScore ();
	}

	void Update () 
	{
		Score = SS.GetScore ();
		ScoreText.text = Score.ToString ();
	}
}
