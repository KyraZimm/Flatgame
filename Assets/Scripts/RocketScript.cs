using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 force = new Vector2(0.1f, 0.1f);
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        force = force * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(force, ForceMode2D.Impulse);
    }
}
