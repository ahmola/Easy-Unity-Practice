using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float jumpPower = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        birdBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            birdBody.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Safe")
        {
            if (CountScore.score > CountScore.bestScore)
            {
                CountScore.bestScore = CountScore.score;
                PlayerPrefs.SetInt("BestScore", CountScore.bestScore);
            }
            SceneManager.LoadScene("GameOverScene");

        }
    }
}
