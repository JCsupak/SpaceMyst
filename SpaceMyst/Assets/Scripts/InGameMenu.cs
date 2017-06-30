using UnityEngine;
using System.Collections;

public class InGameMenu : MonoBehaviour
{

    GameObject[] gameMenuObjects;
    bool menuOpen = false;

	// Use this for initialization
	void Start ()
    {
        gameMenuObjects = GameObject.FindGameObjectsWithTag("GameMenu");
        hideGameMenu();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!menuOpen)
            {
                showGameMenu();
            }
            else
            {
                hideGameMenu();
            }
        }
	}

    public void hideGameMenu()
    {
        menuOpen = false;
        foreach(GameObject g in gameMenuObjects)
        {
            g.SetActive(false);
        }
    }

    public void showGameMenu()
    {
        menuOpen = true;
        foreach(GameObject g in gameMenuObjects)
        {
            g.SetActive(true);
        }
    }

}
