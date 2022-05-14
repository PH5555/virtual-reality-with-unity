using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameScoring gameScoring;
    public Text scoreText;
    // Start is called before the first frame update
    void LateUpdate()
    {
        scoreText.text = gameScoring.score.ToString();
    }
}
