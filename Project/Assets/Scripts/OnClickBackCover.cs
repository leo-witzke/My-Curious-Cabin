using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnClickBackCover : MonoBehaviour
{
    GameObject Album;
    GameObject FrontCover;
    GameObject Page1;
    GameObject Page2;
    GameObject Page3;

    void Awake()
    {
        Album = gameObject.transform.parent.gameObject;
        FrontCover = Album.transform.Find("Front Cover Wrapper").Find("Front Cover").gameObject;
        Page1 = Album.transform.Find("Page 1 Wrapper").Find("Page 1").gameObject;
        Page2 = Album.transform.Find("Page 2 Wrapper").Find("Page 2").gameObject;
        Page3 = Album.transform.Find("Page 3 Wrapper").Find("Page 3").gameObject;
    }

    void OnMouseDown()
    {
        FrontCover.GetComponent<PhotoAlbumRotate>().OnMouseDown();
        FrontCover.GetComponent<Move>().OnMouseDown();
        Page1.GetComponent<Rotate>().OnMouseDown();
        Page2.GetComponent<Rotate>().OnMouseDown();
        Page3.GetComponent<Rotate>().OnMouseDown();
    }
}
