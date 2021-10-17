using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playButton : MonoBehaviour
{
    //Creates button functionality for the main menu
    public void PlayGame ()
    {

        //Loads the level 1 when the play button is pressed
        SceneManager.LoadScene("level1");
    }


}
