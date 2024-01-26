using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushYes : MonoBehaviour
{
    public void PressYes()
    {
        SceneManager.LoadSceneAsync("Open");
    }
}
