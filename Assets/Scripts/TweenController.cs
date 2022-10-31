using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TweenController : MonoBehaviour
{
    public IEnumerator Tween(Quaternion endRotation)
    {
        Transform transform = gameObject.transform;
        Quaternion startRotation = transform.localRotation;
        float time = 0;
        while (Math.Abs(startRotation.x-endRotation.x) + Math.Abs(startRotation.y-endRotation.y) + Math.Abs(startRotation.z-endRotation.z) > 0.01f)
        {
            time += Time.deltaTime;
            transform.localRotation = Quaternion.Lerp(startRotation, endRotation, 1.5f*time);
            yield return null;
        }
        transform.localRotation = endRotation;
    }

    public IEnumerator Tween(Vector3 endPosition)
    {
        Vector3 positionDifference = new Vector3(1,1,1);
        Transform transform = gameObject.transform;
        while (positionDifference.magnitude > 0.01)
        {
            positionDifference = endPosition-transform.localPosition;
            Vector3 deltaPosition = positionDifference*3;
            if (deltaPosition.magnitude < 0.5)
            {
                deltaPosition = 0.5f*deltaPosition/deltaPosition.magnitude;
            }
            if (deltaPosition.magnitude > 5)
            {
                deltaPosition = 5*deltaPosition/deltaPosition.magnitude;
            }
            transform.localPosition = transform.localPosition + deltaPosition*Time.deltaTime;
            yield return null;
        }
        transform.localPosition = endPosition;
    }
}
