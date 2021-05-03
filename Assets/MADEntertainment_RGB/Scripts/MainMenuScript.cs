using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour 
{
	SaveDataScript SDS;
	ScoreScript SS;
	GameObject GameManager;

	public Text HSText;
	int HighScore;

	public Button SoundButton;
	public Image SoundImage;
	public Sprite SoundOnButtonImage,SoundOnImage;
	public Sprite SoundOffButtonImage,SoundOffImage;

	void Start () 
	{
		GameManager = GameObject.FindGameObjectWithTag ("GM");
		SDS = GameManager.GetComponent<SaveDataScript> ();
		SS = GameManager.GetComponent<ScoreScript> ();

		HighScore = SDS.GetHighScore ();
		HSText.text = "Best\n" + HighScore.ToString ();

		if(AudioListener.volume == 0)
		{
			SoundButton.image.overrideSprite = SoundOffButtonImage;
			SoundImage.overrideSprite = SoundOffImage;
		}
		else
		{
			SoundButton.image.overrideSprite = SoundOnButtonImage;
			SoundImage.overrideSprite = SoundOnImage;
		}
	}

	public void Mute()
	{
		if(AudioListener.volume == 1)
		{
			AudioListener.volume= 0;
			SoundButton.image.overrideSprite = SoundOffButtonImage;
			SoundImage.overrideSprite = SoundOffImage;
		}
		else
		{
			AudioListener.volume= 1;
			SoundButton.image.overrideSprite = SoundOnButtonImage;
			SoundImage.overrideSprite = SoundOnImage;
		}
	}

	public void Play()
	{
		SS.ResetScore ();
		SceneManager.LoadScene (2);
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
