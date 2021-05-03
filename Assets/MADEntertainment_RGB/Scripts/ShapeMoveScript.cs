using UnityEngine;
using System.Collections;

public class ShapeMoveScript : MonoBehaviour 
{
	float X,Y;
	int CurrentScore;

	GameObject GameManager;
	ScoreScript SS;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag("GM");
		SS = GameManager.GetComponent<ScoreScript> ();

		X = transform.position.x;
		Y = transform.position.y;
	}
	

	void FixedUpdate () 
	{
		Y -= SS.Difficulty;
		gameObject.transform.position = new Vector3 (X, Y, 0.0f);
	}
}
