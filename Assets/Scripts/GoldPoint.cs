using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldPoint : MonoBehaviour
{
    public int goldPoint;
    public TextMeshProUGUI goldText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D coin)
    {
        if (coin.gameObject.tag == "Gold")
        {
            goldPoint += 1;
            goldText.text = goldPoint.ToString();
        }

        if (coin.gameObject.tag =="GoldBig")
        {
            goldPoint += 3;
            goldText.text = goldPoint.ToString();
        }

        if (coin.gameObject.tag == "Obstacle")
        {
            goldPoint -= 2;
            goldText.text = goldPoint.ToString();
        }
    }
}
