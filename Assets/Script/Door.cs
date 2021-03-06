﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public int LevelToLoad;

    private GameMaster gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            gm.InputText.text = ("[E] to Enter");
            if (Input.GetKeyDown("e"))
            {
                //Application.LoadLevel(ซีนที่จะไป)
                Application.LoadLevel(LevelToLoad);
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(Input.GetKeyDown("e"))
            {
                //Application.LoadLevel(ซีนที่จะไป)
                Application.LoadLevel(LevelToLoad);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = (" ");
        }
    }
}
