using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Vector3 pos;
    Quaternion rot;

    void Start()
    {
        pos = transform.position;
        rot = transform.rotation;
    }
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        float frontBack = Input.GetAxis("Vertical");
        pos.x += leftRight;
        pos.z += frontBack;
        transform.position = pos;
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Quaternion rot = new Quaternion(0f, 90f, 0f, 0f);
            rot.y += 45;
            transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Quaternion rot = new Quaternion(0f, -90f, 0f, 0f);
            rot.y -= 45;
            transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        }
        
    }
}