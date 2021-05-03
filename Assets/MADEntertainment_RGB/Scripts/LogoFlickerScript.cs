using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Main menu RGB logo flicker

public class LogoFlickerScript : MonoBehaviour 
{

	public Text R,G,B;
	int RC,GC,BC;
	int RVal,GVal,BVal;
	
	void Start () 
	{
		RVal = 1;
		GVal = 1;
		BVal = 1;
		Invoke ("RLogoFlicker",Random.Range(0.2f,0.9f));
		Invoke ("GLogoFlicker",Random.Range(0.2f,0.9f));
		Invoke ("BLogoFlicker",Random.Range(0.2f,0.9f));
	}

	void RLogoFlicker()
	{
		R.color = new Color (RVal, 0, 0, 1);

		if (RVal == 1)
			RVal = 0;
		else
			RVal = 1;

		if (RC < 10) 
		{
			Invoke ("RLogoFlicker", 0.1f);
			RC++;
		}
		else
			R.color = new Color (1, 0, 0, 1);
	}

	void GLogoFlicker()
	{
		G.color = new Color (0, GVal, 0, 1);
		
		if (GVal == 1)
			GVal = 0;
		else
			GVal = 1;
		
		if (GC < 10) 
		{
			Invoke ("GLogoFlicker", 0.1f);
			GC++;
		}
		else
			G.color = new Color (0, 1, 0, 1);
	}

	void BLogoFlicker()
	{
		B.color = new Color (0, 0, BVal, 1);
		
		if (BVal == 1)
			BVal = 0;
		else
			BVal = 1;
		
		if (BC < 10) 
		{
			Invoke ("BLogoFlicker", 0.1f);
			BC++;
		}
		else
			B.color = new Color (0, 0, 1, 1);
	}
}
