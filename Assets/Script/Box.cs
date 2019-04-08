using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private PlayerController player;

   

    void Start()
    {
        player = gameObject.GetComponentInParent<PlayerController>();


    }

    void Update()
    {
        player.boxx = true;    
        
    }
}
