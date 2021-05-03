using UnityEngine;
using System.Collections;

public class ObjectsSpawnScript : MonoBehaviour 
{
	[SerializeField]
	GameObject[] NeonSquares;

	[SerializeField]
	Vector3[] SpawnPos;


	void Start () 
	{
		SpawnSquares ();
	}

	void SpawnSquares () 
	{
		Instantiate (NeonSquares[Random.Range(0,3)],SpawnPos[Random.Range(0,3)],Quaternion.identity);
	}

	void OnTriggerEnter2D(Collider2D HitObject)
	{
		if (HitObject.tag == "Red" ||HitObject.tag == "Green" || HitObject.tag == "Blue")
			SpawnSquares ();
	}
}
