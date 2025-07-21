using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClip : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void OnMouseDown()
    {
       source.PlayOneShot(clip);
    }
}
