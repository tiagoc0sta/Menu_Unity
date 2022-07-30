using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    
    public void selectScene()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
