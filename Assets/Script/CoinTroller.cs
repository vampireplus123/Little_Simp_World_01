using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTroller : MonoBehaviour
{
    public static CoinTroller coinController;
    public Text text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if(coinController == null)
        {
            coinController = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeCoin(int coinvalue)
    {
        score += coinvalue;
        text.text = score.ToString();
    }
}
