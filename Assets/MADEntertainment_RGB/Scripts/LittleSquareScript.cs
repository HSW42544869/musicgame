using UnityEngine;
using System.Collections;

//This script animates little white squares in the background.

public class LittleSquareScript : MonoBehaviour 
{
	float X,Y;
	bool Shrink;

	void Start () 
	{
		X = 0.0f;
		Y = 0.0f;
	}

	void Update () 
	{
		transform.Rotate (Vector3.back);

		if (X >= 1.0f)
			Shrink = true;
		if (X <= 0.0f)
			Shrink = false;

		if (Shrink) 
		{
			X -= 0.01f;
			Y -= 0.01f;
		} 
		else 
		{
			X += 0.01f;
			Y += 0.01f;
		}
		transform.localScale = new Vector3 (X,Y,1.0f);
	}
}
