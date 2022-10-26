using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 0f);
    }

}
