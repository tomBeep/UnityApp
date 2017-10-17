using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayMenu : MonoBehaviour
{

    // Update is called once per frame
    public void Update()
    {
        if ((Input.touchCount == 1) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetMouseButtonDown(0))//swaps screens with mouse button click too.
        {
            SceneManager.LoadScene(1);
        }

    }

}

