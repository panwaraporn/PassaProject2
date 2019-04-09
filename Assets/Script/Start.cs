using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void Btnstart(string Story1)
    {
        SceneManager.LoadScene(Story1);
    }
    public void Btnexit()
    {
        Application.Quit();
    }
}
