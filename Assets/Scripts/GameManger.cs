using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;
    public Text mTxtGameover;
    

    public void EndGame()
    {
       
        if (gameHasEnded == false)
        {
            //Debug.Log("Game Over Mehar");
            gameHasEnded = true;
            ScoreScript.scoreValue = 0;
            mTxtGameover.text = "Game Over";
            Restart();
            
        }
        
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
