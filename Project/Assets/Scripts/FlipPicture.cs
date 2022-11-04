using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPicture : MonoBehaviour
{
    void OnMouseDown()
    {
        Animator animator = gameObject.transform.parent.parent.gameObject.GetComponent<Animator>();
        animator.Play("FlipPicture");
    }
}
