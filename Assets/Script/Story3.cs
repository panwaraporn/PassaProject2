using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story3 : MonoBehaviour
{
    public void BtnNext(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
}
