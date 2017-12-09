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
    Animator anim;

    // Use this for initialization
    void Start()
    {
        scoreText = scoreTextGameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 0)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            scoreText.text = "Score: 0";
        }


        if (anim != null)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("bumper_hit"))
            {
                anim.SetFloat("hit", 0);
            }
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bumper_sprite")
        {
            score += scorePerBumperHit;
            collision.gameObject.GetComponent<Animator>().SetFloat("hit", 1);
            anim = collision.gameObject.GetComponent<Animator>();
            GameObject.Find("Main Camera").GetComponent<CameraShake>().ShakeCamera(1f, 0.1f);
        }
        else
        {
            anim = null;
        }
    }


}
