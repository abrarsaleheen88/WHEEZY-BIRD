using System;
using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D playerRb;
    public float force = 10f;
    public GameManager gameManager;
    public float delayTime = 2f; // 2 seconds before Game Over
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D( Collider2D collision)
    {
        if (!gameObject.CompareTag("Enemy"))
        {

            gameManager.GameOver();
            Debug.Log("GameOver");
            Time.timeScale = 0f;// stop the game
            StartCoroutine(GameOverDelay());

        }
    }

    IEnumerator GameOverDelay()
    {
        // Optional: play hit sound, animation here
        yield return new WaitForSecondsRealtime(delayTime); // ignores timeScale
        Time.timeScale = 1f; // reset before changing scene
        SceneManager.LoadScene(2);
    }
}
