using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{


    public int[,] shopItems = new int[5, 5];
    public float coins;
    public Text CoinsTXT;




    // Start is called before the first frame update
    void Start ()
    {
        CoinsTXT.text = "Coins" + coins.ToString();

        shopItems[1, 1] = 10;
        shopItems[1, 2] = 20;
        shopItems[1, 3] = 30;
        shopItems[1, 4] = 40;


        //Price

        shopItems[2, 1] = 10;
        shopItems[2, 2] = 25;
        shopItems[2, 3] = 50;
        shopItems[2, 4] = 80;

        //Quantity

        shopItems[3, 1] = 0;
        shopItems[3, 1] = 0;
        shopItems[3, 1] = 0;
        shopItems[3, 1] = 0;



    }


    public void Buy()

    {
      GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems [2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
    }
   
   
}
