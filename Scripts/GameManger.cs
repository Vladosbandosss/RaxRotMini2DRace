using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    public Text scoretext;
    int score = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
  
    void Start()
    {
        scoretext.text = "0";
    }

   public void IncrementScore()
    {
        score++;
        scoretext.text = score.ToString();

    }
}
