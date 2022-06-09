using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;

    public string[] lines;

    public float textspeed;

    private int index;
    
    // Start is called before the first frame update
   

    void Start()
    {
        textComponent.text = String.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
                
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                Time.timeScale = 0f;
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

   IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

   void NextLine()
   {
       if (index > lines.Length - 1)
       {
           index++;
           textComponent.text = String.Empty;
           StartCoroutine(TypeLine());
       }
       else
       {
           Time.timeScale = 1f;
           gameObject.SetActive(false);
           
       }
   }
}
