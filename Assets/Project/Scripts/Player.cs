﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed = 3f;
    public float SpaceJunk;
    private Rigidbody2D SelfRigid;
    [Range(0f,100f)] public float SpaceJunkCollected = 0f;
    // Start is called before the first frame update
    void Start()
    {
        SelfRigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            SelfRigid.AddForce(Vector3.right*speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SelfRigid.AddForce(Vector3.left*speed);
        }                                                 
      //  transform.Translate(Input.GetAxis("Horizontal")*speed*-1*Time.deltaTime,0f,0f);
    }
    
    void OnCollisionEnter2D (Collision2D collider)
    {
        Debug.Log("hit");
        if (collider.gameObject.GetComponent<SpaceJunk>() != null)
        {
            //make more fuel here
            Destroy(collider.gameObject);
        }
    }
}