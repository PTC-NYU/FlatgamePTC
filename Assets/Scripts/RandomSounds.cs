using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip[] sounds;

    public float minTime = 3f; 
    public float maxTime = 10f;

    private float timer; 
    private bool isplaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (isplaying)
        {

            if (!AudioSource.isPlaying)
            {
                isplaying = false;
                timer = Random.Range(minTime, maxTime);
            }
            
            return;
        }
        
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            playRandom();
        }
    }

    void playRandom()
    {
        if (sounds.Length == 0)
        {
            return;
        }
        
        AudioClip randomClip = sounds[Random.Range(0, sounds.Length)];
        
        AudioSource.clip = randomClip;
        AudioSource.Play();
        
        isplaying = true;
    }
}
