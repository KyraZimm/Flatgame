using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    private bool fadeIn = true;
    private bool fadedOut = false;
    private Image img;
    
    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn)
        {
                StartCoroutine(FadeIn());
                
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
                StartCoroutine(FadeOut());
        }
        
        
        
    }

    IEnumerator FadeIn()
    {
        for (float i = 0; i <= 0.5f; i += Time.deltaTime)
        {
            img.color = new Color(0, 0, 0, i);
            yield return null;
        }
    }
    
    IEnumerator FadeOut()
    {
        for (float i = 0.5f; i >= 0; i -= Time.deltaTime)
        {
            img.color = new Color(0, 0, 0, i);
            yield return null;
        }
    }
}
