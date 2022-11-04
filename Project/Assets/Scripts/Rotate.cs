using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotate : MonoBehaviour
{
    public Quaternion end;
    public GameObject TweenMe;

    Quaternion start;

    void Start()
    {
        start = getRotation();
    }

    Coroutine rotating;
    void move(Quaternion rotation) {
        if (rotating != null) {
            StopCoroutine(rotating);
        }
        rotating = StartCoroutine(TweenMe.GetComponent<TweenController>().Tween(rotation));
    }

    Quaternion getRotation() {
        return TweenMe.transform.localRotation;
    }
    float RotationDifference(Quaternion rotation1, Quaternion rotation2)
    {
        return Math.Abs(rotation1.x-rotation2.x) + Math.Abs(rotation1.y-rotation2.y) + Math.Abs(rotation1.z-rotation2.z);
    }

    public void OnMouseDown()
    {
        if (RotationDifference(start, getRotation()) > 0.01f) {
            move(start);
        }
        else
        {
            move(end);
        }
    }
}
