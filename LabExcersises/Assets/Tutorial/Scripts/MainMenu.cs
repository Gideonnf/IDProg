using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Awake()
    {
      //Object Managers only  
      //Call child Init() function
    }

    public void GameScene()
    {
        SceneManager.LoadScene("Done_Main");
    }
    // Use this for initialization
    public void Init()
    {
        //init for other objects
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
