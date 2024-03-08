using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFeedbackDistance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arduinoData;
    ReadArduino data;
    [SerializeField] AudioClip[] clips; // drag and add audio clips in the inspector
    AudioSource audioSource;
    int state;
    void Start()
    {
        // Starting in 2 seconds, every 0.3 there will be audio feedback provided.
         data = arduinoData.GetComponent<ReadArduino>();
         audioSource = GetComponent<AudioSource>();
         InvokeRepeating("LaunchAudioFeedback", 2.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void LaunchAudioFeedback()
    {
        int distance = data.getDistance();

       if(distance >= 50)
            Debug.Log("all good");
        else if (distance < 50 && distance > 25)
            {
                OutputFeedback(0);

            }
        else if(distance <= 25)
                OutputFeedback(1);

    }

     void OutputFeedback(int clipIndex) // the index of the sound, 0 for first sound, 1 for the 2nd..etc
    {
        // use one desired logic
        // this will make only one sound to play without interruption
        audioSource.clip = clips[clipIndex];
        audioSource.Play();
 
        // this will make multiple sound to play with interruption
        audioSource.PlayOneShot(clips[clipIndex]);
    }
}
