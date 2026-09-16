using UnityEngine;

public class LookDownDetector : MonoBehaviour
{
    public Transform flashlight;

    public float minYpos = -7f;
    
    private bool lookingDown = false;

    public GameObject[] suspects;
    public GameObject[] hallucinations;
    public AudioClip[] sounds;
    
    private int suspectIndex = 0; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flashlight.position.y <= minYpos)
        {
            lookingDown = true;
        }

        if (lookingDown && flashlight.position.y > minYpos)
        {
            lookingDown = false;

            nextSuspect(); 
        }
    }
    
    void nextSuspect()
    {
        suspects[suspectIndex].SetActive(false);
        hallucinations[suspectIndex].SetActive(false);
        
        suspectIndex++;
        playSound();

        if (suspectIndex >= suspects.Length)
        {
            suspectIndex = 0;
        }
        
        suspects[suspectIndex].SetActive(true);
        hallucinations[suspectIndex].SetActive(true);
    }

    void playSound()
    {
        if (sounds.Length == 0)
        {
            return;
        }
        
        AudioClip sound =  sounds[suspectIndex];
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
