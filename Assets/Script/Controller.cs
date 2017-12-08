using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public GameObject lever_0;
    public GameObject lever_1;
    public GameObject ball;
    private float maxAngle = 45;
    private float originalAngle = 12.559f;
    private float angleIncreaseAmount = 500f;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //left arrow = left lever moves up
        //right arrow = right lever moves up
        //up arrow = both lever move up

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (-(lever_0.transform.eulerAngles.z - 360) <= maxAngle)
            {
                lever_0.transform.Rotate(Vector3.forward * Time.deltaTime * angleIncreaseAmount);
            }
        }
        else
        {
            lever_0.transform.rotation = Quaternion.Euler(0, 0, -originalAngle);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            if ((lever_0.transform.eulerAngles.z - 360) <= -maxAngle)
            {
                lever_1.transform.Rotate(Vector3.forward * Time.deltaTime * angleIncreaseAmount);
            }
        }
        else
        {
            lever_1.transform.rotation = Quaternion.Euler(0, 180, -originalAngle);
        }

    }
}
