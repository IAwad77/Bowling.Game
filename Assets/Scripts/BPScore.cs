using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPScore : MonoBehaviour
{
    public static int score;

    int pinstotal = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitL") 
        {
            AddScore(1);
            Destroy(gameObject, 1.0f);
        }
       
    }
    void AddScore(int amount)
    {
        score += amount;
        ScoreTally.instance.UpdateUI(score, pinstotal);
    }
}
