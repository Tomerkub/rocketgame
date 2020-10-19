using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceJunk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   //     transform.Translate(1f,0f,0f);
    }   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            collider.GetComponent<Player>().SpaceJunk+=1;
            Destroy(gameObject);
        }
    }
    public void SetPosition(float x,float y)
    {
        transform.position = new Vector3 (x,y,0f);
    }
}
