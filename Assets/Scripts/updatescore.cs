using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class updatescore : MonoBehaviour
{
    public Text scoretext;
    public int score;

    private void Start()
    {
        FirstClass.instance.onCoinCollection += updatemyscore;
    }
    private void updatemyscore()
    {
        score += 1;
        scoretext.text = score.ToString();


    }

    private void OnDestroy()
    {
       FirstClass.instance.onCoinCollection -= updatemyscore;
    }
}
