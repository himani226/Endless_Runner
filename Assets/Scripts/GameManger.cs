using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // This script to handle the Scores display on top of the game.
    public int score;
    public static GameManger inst;

    public Text scoreText;

    // Increment the score value at text UI 
    public void IncrementScore(){
        score++;
        scoreText.text = "SCORE: " + score;
    }

    private void Awake()
    {
        inst = this;
    }
}
