using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardinal : Bird
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            SingAndDebug("Cardinal");
        }
    }

    // POLYMORPHISM
    public override void Sing()
    {
        audioClip.Play();
    }
}
