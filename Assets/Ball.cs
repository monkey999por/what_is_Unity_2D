using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private new Rigidbody2D rigidbody2D;

    public float speedX = 200;
    public float speedy = 200;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player");
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector2(speedX, speedy));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
