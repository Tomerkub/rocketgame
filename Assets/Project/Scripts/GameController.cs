using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float spacejunkSpawnRatePerSecond;
    private float timer = 0f;
    public GameObject SpaceJunk1;
    public GameObject SpaceJunk2;
    public GameObject SpaceJunk3;
    private int spawner = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>=spacejunkSpawnRatePerSecond)
        {
            spawner = Random.Range(1,4);
            if (spawner==1)
                Instantiate(SpaceJunk1);
            if (spawner==2)
                Instantiate(SpaceJunk2);
            if (spawner==3)
                Instantiate(SpaceJunk3);
            timer = 0f;
        }
    }
}
