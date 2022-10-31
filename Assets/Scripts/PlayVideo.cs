using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer player;
    public GameObject WebBuildScreen;

    void OnMouseDown()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            WebBuildScreen.SetActive(true);
        }
        else
        {
            player.Play();
        }
    }
}
