using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story2 : MonoBehaviour
{
    public void BtnNext(string Story3)
    {
        SceneManager.LoadScene(Story3);
    }
}
