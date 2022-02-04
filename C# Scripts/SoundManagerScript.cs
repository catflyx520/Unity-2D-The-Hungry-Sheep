using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip eatSound;
    public static AudioClip bgMusicDay;
    public static AudioClip bgMusicNight;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        eatSound = Resources.Load<AudioClip>("chewy");
        bgMusicDay = Resources.Load<AudioClip>("daytime");
        bgMusicNight = Resources.Load<AudioClip>("nighttime");
        audioSource = GetComponent<AudioSource>();
    }

    public static void playMusicDay()
    {
        Debug.Log("Should play daytime music");
        audioSource.PlayOneShot(bgMusicDay);
    }

    public static void playMusicNight()
    {
        Debug.Log("Should play nighttime music");
        audioSource.PlayOneShot(bgMusicNight);
    }

    public static void playSound()
    {
        Debug.Log("Ate food.");
        audioSource.PlayOneShot(eatSound);
    }
}
