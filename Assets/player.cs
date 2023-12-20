using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   
    private SpriteRenderer renderer;

    int playerSpeed = 5;
    Rigidbody2D rid2D;

    private void Start()
    {
        rid2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    { 
        PlayerMove();
    }
    void PlayerMove()
    {   

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("poop"))
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}

