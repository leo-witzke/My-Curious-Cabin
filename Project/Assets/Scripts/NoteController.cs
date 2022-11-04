using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public GameObject note;

    void OnMouseDown()
    {
        note.SetActive(true);
        note.GetComponent<OpenCloseNote>().open();
    }
}
