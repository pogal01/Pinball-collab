using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float moveAmount = 25;
    public GameObject Ball;
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = Ball.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -1.83f)
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 1.71f)
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveAmount);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 100);
        }

        if (Ball.transform.position.y < -5.19f)
        {
            Ball.transform.position = new Vector2(0, 4);
            rb.velocity = new Vector3(0, 0, 0);
        }

    }

   


}
