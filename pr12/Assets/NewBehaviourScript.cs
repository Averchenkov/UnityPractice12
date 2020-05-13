using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void StartScene()
    {
        Application.LoadLevel("Scene2");
    }

    public void Options(GameObject window)
    {
        window.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
