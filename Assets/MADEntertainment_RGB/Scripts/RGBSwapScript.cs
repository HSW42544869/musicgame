using UnityEngine;
using System.Collections;

public class RGBSwapScript : MonoBehaviour 
{
	[SerializeField]
	GameObject LeftPS,CenterPS,RightPS;
	GameObject TempPS;
	Vector3 TempPos;

	bool AllowClick = true;

	void Start () 
	{
	
	}

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if(Input.mousePosition.x < Screen.width/2 && AllowClick)
			{	
				SwapLeft();
			}
			if(Input.mousePosition.x > Screen.width/2 && AllowClick)
			{	
				SwapRight();
			}
		}
	}

	void SwapLeft()
	{
		TempPos = LeftPS.transform.position;
		LeftPS.transform.position = CenterPS.transform.position;
		CenterPS.transform.position = TempPos;

		TempPS = LeftPS;
		LeftPS = CenterPS;
		CenterPS = TempPS;
	}

	void SwapRight()
	{
		TempPos = CenterPS.transform.position;
		CenterPS.transform.position = RightPS.transform.position;
		RightPS.transform.position = TempPos;
		
		TempPS = CenterPS;
		CenterPS = RightPS;
		RightPS = TempPS;
	}

	public void SetAllowClick(bool val)
	{
		AllowClick = val;
	}
}
