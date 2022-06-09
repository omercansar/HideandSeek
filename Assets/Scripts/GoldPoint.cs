using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldPoint : MonoBehaviour
{
    public int goldPoint;
    public TextMeshProUGUI goldText;
    public GameObject wincondition;
    public int key = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goldPoint == 10)
        {
            wincondition.SetActive(true);
            Time.timeScale = 0f;
        }
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
            goldPoint -= 4;
            goldText.text = goldPoint.ToString();
        }

        if (coin.gameObject.tag == "Key")
        {
            key += 1;
        }

        if (coin.gameObject.tag == "Door")
        {
            if (key == 1)
            {
                wincondition.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
