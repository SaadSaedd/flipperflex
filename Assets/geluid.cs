using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geluid : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;




    public void Playsound()
    {
        source.PlayOneShot(clip);
    }
    

    
}
