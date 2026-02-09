using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject barrier;
   
   
   
    private float start = 2f;
    private float repeat = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Start()
    {

        InvokeRepeating("SpawnManager", start, repeat);

    }

    // Update is called once per frame
      void SpawnManager()
    {
        float randomY = Random.Range(-3f, 3f);
        Vector2 spawnPos = new Vector2(15, randomY);
        Instantiate(barrier, spawnPos, barrier.transform.rotation);

    }

    public void GameOver()
    {
        
            Debug.Log("GAME OVER");
        //Time.timeScale = 0f;
        SceneManager.LoadScene(2);


    }
    
}
