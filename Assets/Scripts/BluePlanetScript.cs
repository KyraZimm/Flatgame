using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlanetScript : MonoBehaviour
{
    public GameObject rocket;
    private Vector2 force = new Vector2(3f, 3f);
    private Vector3 rocketCoords = new Vector3(-16.3f, -14f, 5);
    private bool rocketCreated = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger detected");
        if (col.gameObject.tag == "Camera")
        {
            Debug.Log("camera detected");
            if (rocketCreated == false)
            {
                GameObject newRocket = Instantiate(rocket, rocketCoords, Quaternion.identity);
                newRocket.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
                rocketCreated = true;
            }
           
        }
    }
}
