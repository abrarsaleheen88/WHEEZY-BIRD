using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public  float score = 0;  

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update( )
    {  if (Time.timeScale == 0) return ;  // stop scores
        score = score + (-player.transform.position.x)/ 1000f;
        scoreText.text = "Score :" +  Mathf.FloorToInt(score);
    }
}
