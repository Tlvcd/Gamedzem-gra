using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicscript : MonoBehaviour
{
    private AudioSource asAudioManager;
    private float durationOfLastClip;
    private float Timer;
    public AudioClip[] soundClips;
    // Start is called before the first frame update
    void Start()
    {
        asAudioManager = GetComponent<AudioSource>();
        musicChange(Random.Range(0, 5));
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= durationOfLastClip)
        {
            musicChange(Random.Range(0, 5));
        }

    }
    public void musicChange(int whichSound)
    {
        if (asAudioManager.isPlaying)
        {
            asAudioManager.Stop();
        }
        asAudioManager.clip = soundClips[whichSound];
        durationOfLastClip = asAudioManager.clip.length;
        asAudioManager.Play();
    }
}
