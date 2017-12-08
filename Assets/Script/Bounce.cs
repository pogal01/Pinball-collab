using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public GameObject ball;
    Rigidbody2D rb;
    public GameObject lever_1;
    private float maxAngle = 45;
    private float originalAngle = 12.559f;
    private float angleIncreaseAmount = 200f;
    public  bool activated = false;

    void Start()
    {
        rb = ball.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {


            if (lever_1.transform.eulerAngles.z >= maxAngle)
            {
                lever_1.transform.Rotate(Vector3.forward * Time.deltaTime * angleIncreaseAmount);
                activated = true;
            }
        }
        else
        {
            lever_1.transform.rotation = Quaternion.Euler(0, 180, -originalAngle);
            activated = false;
        }
    }

    public void OnCollision2D(Collision2D collision)
    {
        if (activated) rb.AddForce(Vector2.up * 100);
        Debug.Log(":D");
    }

}
