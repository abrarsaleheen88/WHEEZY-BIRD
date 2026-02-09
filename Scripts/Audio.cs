using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.loop = true;
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
