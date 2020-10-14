using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[ExecuteInEditMode]
public class MainCamera : MonoBehaviour
{
    private Vector3 Position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Position = new Vector3 (0f,GameObject.Find("Rocket").transform.position.y - 2.39f,-10f);
        transform.position = Position;
    }
}
