using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerProcessor : MonoBehaviour
{
    bool HeightChartSolved = false;
    bool TVSolved = false;
    bool PhotoAlbumSolved = false;

    public void checkAnswer(string answer)
    {
        answer = answer.ToLower().Trim();
        Debug.Log("-"+answer+"-");
        if (answer == "gary")
        {
            GameObject puzzle = gameObject.transform.Find("Police Height Chart Wrapper").Find("Police Height Chart Puzzle").Find("Wrapper").Find("Plane").gameObject;
            puzzle.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            HeightChartSolved = true;
        }
        else if (answer == "ice king")
        {
            GameObject puzzle = gameObject.transform.Find("TV").Find("Plane").gameObject;
            puzzle.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            GameObject puzzleWeb = gameObject.transform.Find("TV").Find("Web Build").gameObject;
            puzzleWeb.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            TVSolved = true;
        }
        else if (answer == "dr. two-brains" || 
                 answer == "dr. two briains" || 
                 answer == "two-brains" ||
                 answer == "two brains" ||
                 answer == "dr two-brains" ||
                 answer == "dr two brains" ||
                 answer == "two brain" ||
                 answer == "two-brain")
        {
            GameObject puzzleFront = gameObject.transform.Find("Photo Album").Find("Front Cover Wrapper").Find("Front Cover").gameObject;
            puzzleFront.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            GameObject puzzleBack = gameObject.transform.Find("Photo Album").Find("Back Cover").gameObject;
            puzzleBack.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.green);
            PhotoAlbumSolved = true;
        }
        if (HeightChartSolved && TVSolved && PhotoAlbumSolved)
        {
            Debug.Log("Here");
            gameObject.transform.Find("Fence Type3 Door").gameObject.GetComponent<OpenDoor>().OpenAnimation();
        }
    }
}
