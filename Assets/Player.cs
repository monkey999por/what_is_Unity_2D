using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 100f;

    private new Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = Vector2.zero;
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        
        if (Input.GetKey(KeyCode.A))
        {
            v = new Vector2(speed * -1, 0);
            Debug.Log("press A");
            //rigidbody2D.AddForce(new Vector2(1, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("press S");
            v = new Vector2(speed * 1, 0);
        }

        rigidbody2D.MovePosition(rigidbody2D.position + v * Time.deltaTime);
        
    }
}
