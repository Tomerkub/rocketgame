﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 Middle;
    public Vector3 Left;
    public Vector3 Right;
    public Vector3 CurrentPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Middle)
            CurrentPosition = Middle;
        if (transform.position == Left)
            CurrentPosition = Left;
        if (transform.position == Right)
            CurrentPosition = Right;
      /*  if (Input.GetKeyDown("a") || Input.GetKeyDown("LeftArrow"))
        {
            transform.position = Vector3.Lerp()
        }*/
    }
}