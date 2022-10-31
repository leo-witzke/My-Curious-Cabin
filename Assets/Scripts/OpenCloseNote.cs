using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseNote : MonoBehaviour
{
    GameObject answerInput;

    void Awake()
    {
        answerInput = GameObject.Find("Answer Input").gameObject;
    }

    public void open()
    {
        answerInput.SetActive(false);
        gameObject.SetActive(true);
    }

    public void close()
    {
        answerInput.SetActive(true);
        gameObject.SetActive(false);
    }
}
