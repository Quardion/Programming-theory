using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : Bird
//INHERITANCE
{
    //ENCAPSULATION
    private int m_timesCrowSang;
    public int timesCrowSang
    {
        get { return m_timesCrowSang; }
        set { m_timesCrowSang = value; }
    }

    AudioSource audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SingAndDebug("Crow");
        }
    }

    // POLYMORPHISM
    public override void Sing()
    {
        audioClip.Play();
        Debug.Log("Crow sang " + timesCrowSang + " times!");
        timesCrowSang += 1;
    }
}
