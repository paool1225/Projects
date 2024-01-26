using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class letter : MonoBehaviour
{
    public void OpenLetter()
    {
        SceneManager.LoadSceneAsync("Letter");
    }
}
