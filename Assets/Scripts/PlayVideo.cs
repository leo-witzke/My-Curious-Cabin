using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer player;

    void OnMouseDown()
    {
        player.Play();
    }
}
