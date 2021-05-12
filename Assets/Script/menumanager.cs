using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        Invoke("DelayStart", 2.5F);
    }
    private void DelayStart()
    {
        SceneManager.LoadScene("關卡");
    }

    // Update is called once per frame
    public void Quit()
    {
        Invoke("DelayQuit", 2.5F);
    }
    private void DelayQuit()
    {
        Application.Quit();
    }
}
