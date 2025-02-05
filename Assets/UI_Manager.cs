using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_Manager: MonoBehaviour
{
    public int ScoreCount;
    private int Amount =150;
    public TextMeshProUGUI ScoreTXT;


    public void PlusScore()
    {
        ScoreCount += Amount;
        if (ScoreCount > 0)
        {
            ScoreTXT.color = Color.green;
        }
        else ScoreTXT.color = Color.yellow;
        UpdateScore();
    }
    public void NegativeScore()
    {
        ScoreCount -= Amount;
        if (ScoreCount < 0)
        {
            ScoreTXT.color = Color.red;
        }
        else ScoreTXT.color = Color.yellow;
        UpdateScore();
    }
    public void ResetScore()
    {
        ScoreCount = 0;
        if (ScoreCount == 0) ScoreTXT.color = Color.yellow;

        UpdateScore();
    }

    public void UpdateScore()
    {
        ScoreTXT.text = $"Ducky Stocks: {ScoreCount.ToString("N0")}";
    }
}
