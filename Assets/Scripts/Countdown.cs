using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
	public float timeStart = 5;
	public Text textBox;
	public GameObject END;

	// Use this for initialization
	void Start()
	{
		textBox.text = timeStart.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		if (timeStart > 0)
		{

			timeStart -= Time.deltaTime;
			textBox.text = Mathf.Round(timeStart).ToString();
		}
		else
        {
			textBox.text = "GameOver!";
			Debug.Log ("GameOver");
	

			
			END.SetActive(true);
			Time.timeScale = 0f;
		}

	}
}