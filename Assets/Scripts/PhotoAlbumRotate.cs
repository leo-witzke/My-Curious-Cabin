using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PhotoAlbumRotate : MonoBehaviour
{
    public Quaternion AlbumEnd;
    public Quaternion CoverEnd;

    public GameObject PhotoAlbum;
    public GameObject FrontCover;

    Quaternion AlbumStart;
    Quaternion CoverStart;

    void Start()
    {
        AlbumStart = getRotation(PhotoAlbum);
        CoverStart = getRotation(FrontCover);
    }

    Coroutine rotatingAlbum;
    Coroutine rotatingCover;
    void rotate(Quaternion AlbumRotation, Quaternion CoverRotation) {
        if (rotatingAlbum != null)
        {
            StopCoroutine(rotatingAlbum);
        }
        if (rotatingCover != null)
        {
            StopCoroutine(rotatingCover);
        }
        rotatingAlbum = StartCoroutine(PhotoAlbum.GetComponent<TweenController>().Tween(AlbumRotation));
        rotatingCover = StartCoroutine(FrontCover.GetComponent<TweenController>().Tween(CoverRotation));
    }

    Quaternion getRotation(GameObject obj) {
        return obj.transform.localRotation;
    }

    float RotationDifference(Quaternion rotation1, Quaternion rotation2)
    {
        return Math.Abs(rotation1.x-rotation2.x) + Math.Abs(rotation1.y-rotation2.y) + Math.Abs(rotation1.z-rotation2.z);
    }

    void OnMouseDown()
    {
        if (RotationDifference(AlbumStart, getRotation(PhotoAlbum)) > 0.01f) {
            rotate(AlbumStart, CoverStart);
        }
        else
        {
            rotate(AlbumEnd, CoverEnd);
        }
    }
}
