using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 end;
    public GameObject TweenMe;

    Vector3 start;

    void Start()
    {
        start = getPosition();
    }

    Coroutine moving;
    void move(Vector3 position) {
        if (moving != null) {
            StopCoroutine(moving);
        }
        moving = StartCoroutine(TweenMe.GetComponent<TweenController>().Tween(position));
    }

    Vector3 getPosition() {
        return TweenMe.transform.localPosition;
    }

    public void OnMouseDown()
    {
        if ((start-getPosition()).magnitude > 0.01f) {
            move(start);
        }
        else
        {
            move(end);
        }
    }
}
