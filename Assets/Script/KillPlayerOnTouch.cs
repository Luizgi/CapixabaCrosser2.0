﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTouch : MonoBehaviour
{
    [SerializeField] MenuController controller;
    private void OnCollisionEnter(Collision collision){

    if(collision.collider.GetComponent<Player>() != null){
        Destroy(collision.gameObject);
            Debug.Log("Colidiu");
    }
   }
}
