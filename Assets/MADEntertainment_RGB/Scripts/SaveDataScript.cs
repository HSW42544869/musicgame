using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveDataScript : MonoBehaviour 
{
	int HighScore;

	void Start () 
	{
		Load ();
	}

	public int GetHighScore()
	{
		return HighScore;
	}

	public void SetHighScore(int NewScore)
	{
		HighScore = NewScore;
	}

	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/PlayerData.dat");
		
		PlayerData data = new PlayerData();
		data.HighScore = HighScore;
		
		bf.Serialize (file,data);
		file.Close ();
	}
	
	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/PlayerData.dat")) 
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/PlayerData.dat",FileMode.Open);
			
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();
			
			HighScore = data.HighScore;
		}
	}
}

[Serializable]
class PlayerData
{
	public int HighScore;
}

