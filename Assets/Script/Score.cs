using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 0;
    public int scorePerBumperHit = 100;
    public GameObject scoreTextGameObject;
    public float maxBumperSize = 0.4f;
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText = scoreTextGameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bumper_sprite")
        {
            score += scorePerBumperHit;
        }
    }
}
