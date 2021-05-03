using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CheckForMatch : MonoBehaviour 
{
	GameObject GameManager;
	ScoreScript SS;
	public GameObject Blast;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag ("GM");
		SS = GameManager.GetComponent<ScoreScript> ();
	}

	void OnTriggerEnter2D(Collider2D HitObject)							// This function will be called when the object collides with other objests.
	{
		if (HitObject.tag == gameObject.tag) 
		{
			SS.AddScore ();												// Score is increased if collected in correct box.
			Destroy(gameObject);
		}
		else if(HitObject.tag != "ObjectSpawner")
		{
			Instantiate(Blast,transform.position,Quaternion.identity);	// Game over if collected in wrong box.
			gameObject.GetComponent<Renderer>().enabled = false;

			SceneManager.LoadScene(3);								// Game over if a reward video is already seen.
			Destroy(gameObject);
		}
	}
}
