using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
