using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    AudioSource audioClipDummy;
    // Start is called before the first frame update
    void Start()
    {
        audioClipDummy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //ABSTRACTION
    public void SingAndDebug(string s)
    {
        Sing();
        DebugInfo(s);
    }

    public virtual void Sing()
    {
        audioClipDummy.Play();
    }


    // szkoda czasu na animacje, dawaj info w debugu po prostu zalezne od ptaka
    public void DebugInfo(string s)
    {
        Debug.Log("A beautiful " + s + " sings");
    }
}
