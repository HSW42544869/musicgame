using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour 
{
	SaveDataScript SDS;
	ScoreScript SS;
	GameObject GameManager;
	
	public Text HSText,ScoreText;
	int HighScore, Score;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag ("GM");
		SDS = GameManager.GetComponent<SaveDataScript> ();
		SS = GameManager.GetComponent<ScoreScript> ();

		HighScore = SDS.GetHighScore ();
		Score = SS.GetScore ();

		ScoreText.text = "Score\n" + Score.ToString ();

		CheckForHighScore ();
	}

	void CheckForHighScore()
	{
		if (Score > HighScore) 									// Checks if current score is more than the current HighScore
		{
			HighScore = Score;
			HSText.text = "Best\n" + HighScore.ToString ();

			SDS.SetHighScore (HighScore);
			SDS.Save ();
		}
		else
			HSText.text = "Best\n" + HighScore.ToString ();
	}

	public void Play()
	{
		SceneManager.LoadScene (2);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene (1);
	}
}
