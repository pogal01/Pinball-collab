using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public float moveAmount = 25;
    public GameObject Ball;
    Rigidbody2D rb;
    public float jumpCoolDown = 250;
    public float currentJumpCooldown = 0;
    public GameObject coolDownBar;
    RectTransform rectT;

    // Use this for initialization
    void Start () {
        rb = Ball.GetComponent<Rigidbody2D>();
        rectT = coolDownBar.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -4.5f)
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 4.8f)
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveAmount);
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentJumpCooldown == 0)
        {
            rb.AddForce(Vector2.up * 100);
            currentJumpCooldown = jumpCoolDown;
            rectT.sizeDelta = new Vector2(0, 20.88f);
        }

        if (currentJumpCooldown > 0)
        {
            if (currentJumpCooldown > 0)
            {
                currentJumpCooldown -= 1;
                rectT.sizeDelta = new Vector2(100 - (((currentJumpCooldown / 10) * 4)), 20.88f);
            }
        }

        if (Ball.transform.position.y < -6)
        {
            Ball.transform.position = new Vector2(0, 4);
            rb.velocity = new Vector3(0, 0, 0);
            currentJumpCooldown = 0;
            rectT.sizeDelta = new Vector2(100, 20.88f);
        }

    }

   


}
