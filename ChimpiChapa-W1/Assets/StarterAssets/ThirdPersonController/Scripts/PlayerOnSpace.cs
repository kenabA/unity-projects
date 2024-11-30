using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpace : MonoBehaviour // extends ko satto ':'
{
    public AudioSource audioOne, audioTwo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioOne.Play();
            audioTwo.Stop();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioOne.Stop();
            audioTwo.Play();
        }
    }
}
