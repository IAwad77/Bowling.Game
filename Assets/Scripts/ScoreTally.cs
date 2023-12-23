using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTally : MonoBehaviour
{
    public static ScoreTally instance;
    public Text pinScore;

    public void UpdateUI(int score, int pinstotal)
    {
        pinScore.text = "Your score is:" + score + "/" + pinstotal;
    }



}
