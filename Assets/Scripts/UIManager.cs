using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // This is the button function
    public void buttonStartGame()
    {
        //change scene
        SceneManager.LoadScene("MainLevel");
    }

}
