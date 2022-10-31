using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool open = false;

    void OnMouseDown()
    {
        OpenAnimation();
    }

    public void OpenAnimation()
    {
        if (!open)
        {
            Animator animator = gameObject.GetComponent<Animator>();
            animator.Play("Open");
            open = true;
        }
    }
}