using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject background;
    public GameObject gameOver;
    private bool gameOverEnabled;

    // Update is called once per frame
    void Start()
    {
        gameOverEnabled = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            background.SetActive(false);
            
        }

        if (gameOverEnabled == false)
        {
            gameOver.SetActive(false);
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
