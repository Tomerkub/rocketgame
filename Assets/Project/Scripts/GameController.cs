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
            {
                GameObject spaceJunk1 = Instantiate (SpaceJunk1);
                spaceJunk1.GetComponent<SpaceJunk>().SetPosition(Random.Range(-5.8f,5.8f),-4f);
            }
            if (spawner==2)
            {
                GameObject spaceJunk2 = Instantiate (SpaceJunk2);
                spaceJunk2.GetComponent<SpaceJunk>().SetPosition(Random.Range(-5.8f,5.8f),-4f);
            }
            if (spawner==3)
            {
                GameObject spaceJunk3 = Instantiate (SpaceJunk3);
                spaceJunk3.GetComponent<SpaceJunk>().SetPosition(Random.Range(-5.8f,5.8f),-4f);
            }
            timer = 0f;
        }
    }
}
