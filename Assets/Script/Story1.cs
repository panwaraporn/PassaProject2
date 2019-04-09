using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{
    public void BtnNext(string Story2)
    {
        SceneManager.LoadScene(Story2);
    }
}
