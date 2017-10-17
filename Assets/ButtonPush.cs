using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPush : MonoBehaviour
{

    public void displayGame()//swaps the screen to the game scene
    {
        SceneManager.LoadScene(0);
    }
}
