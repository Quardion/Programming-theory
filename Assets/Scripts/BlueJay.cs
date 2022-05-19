using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueJay : Bird
//INHERITANCE
{
    AudioSource audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SingAndDebug("Blue Jay");
        }
    }

    // POLYMORPHISM
    public override void Sing()
    {
        audioClip.Play();
    }
}
