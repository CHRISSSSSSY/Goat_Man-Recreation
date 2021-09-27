using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour
{
    public AudioClip introMusic;
    public AudioClip generalMusic;
    private AudioSource music;
    public float playTime = 15f;
    // Start is called before the first frame update
    
    
    
    void Start()
    {
        music = GetComponent<AudioSource>();
        StartCoroutine(ChangingSong());
    }




    IEnumerator ChangingSong()
    {
        music.clip = introMusic;
        music.Play();
        yield return new WaitForSeconds(playTime);
        music.Stop();
        music.clip = generalMusic;
        music.Play();
    }
}

