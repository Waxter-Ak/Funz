using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public Transform[] pictures;

    public GameObject winText;

    public static bool youwin;

    private void Start()
    {

        winText.SetActive(false);
        youwin= false;

    }

    void Update()
    {

        if (pictures[0].rotation.z == 0 && pictures[1].rotation.z == 0 && pictures[2].rotation.z == 0 && pictures[3].rotation.z == 0 && pictures[4].rotation.z == 0 && pictures[5].rotation.z == 0)
        {
            youwin = true;
            winText.SetActive(true);
           
        }
    }
}
