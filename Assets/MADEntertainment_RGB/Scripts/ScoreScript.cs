using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour 
{
	int Score;
	int NextLevel;
	public int NumberOfPlays;

	public Text ScoreText;
	public float Difficulty;

	void Start () 
	{
		DontDestroyOnLoad (gameObject);
		Difficulty = 0.02f;
		NextLevel = 15;
	}

	public void AddScore()
	{
		Score++;

		if (Score == NextLevel)
			LevelUp ();
	}

	public void LevelUp()
	{
		Difficulty += 0.01f;
		NextLevel += 15;
	}

	public int GetScore()
	{
		return Score;
	}

	public void ResetScore()
	{
		Score = 0;
		Difficulty = 0.02f;
		NextLevel = 15;
	}
}
