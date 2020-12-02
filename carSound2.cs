using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSound2 : MonoBehaviour
{
    [SerializeField]
    private AudioClip ButDown, ButUp;

    private AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

    }



    public void PlayUpSound()
    {
        audioSrc.PlayOneShot(ButUp);


    }

    public void PlayDownSound()
    {
        audioSrc.PlayOneShot(ButDown);
        audioSrc.Stop();
    }
}
