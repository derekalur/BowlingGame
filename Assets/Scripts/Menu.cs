using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    
}
