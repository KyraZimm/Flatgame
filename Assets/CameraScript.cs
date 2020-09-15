using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if (gameObject.transform.position.y < 10)
            {
                transform.Translate(0, 0.2f, 0);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (gameObject.transform.position.y > -10)
            {
                transform.Translate(0, -0.2f, 0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (gameObject.transform.position.x < 10)
            {
                transform.Translate(0.2f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (gameObject.transform.position.x > -10)
            {
                transform.Translate(-0.2f, 0, 0);
            }
        }
        
    }
}
