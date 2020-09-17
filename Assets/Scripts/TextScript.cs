using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public List<Text> text = new List<Text>();

    private bool fadeIn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn)
        {
            for (int i = 0; i < text.Count; i++)
            {
                StartCoroutine(FadeIn(text[i]));
            }
            
            if (Input.GetKeyDown(KeyCode.W)
                || Input.GetKeyDown(KeyCode.A)
                || Input.GetKeyDown(KeyCode.S)
                || Input.GetKeyDown(KeyCode.D))
            {
                StopAllCoroutines();
                fadeIn = false;
            }
        }
        else
        {
        
            for (int i = 0; i < text.Count; i++)
            {
                StartCoroutine(FadeOut(text[i]));
            }
            
        }
        
        
        
    }
    IEnumerator FadeIn(Text thisText)
    {
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            thisText.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }
    
    IEnumerator FadeOut(Text thisText)
    {
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            thisText.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }
}
