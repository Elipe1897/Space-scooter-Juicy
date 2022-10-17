using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // Fires the bullet downwards 
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      // when this objetcs collides with one of theese tag it destroys itself 
        if(collision.transform.tag == "Sheild" || collision.transform.tag == "SpaceShip" || collision.transform.tag == "Fire")
        {
            Destroy(gameObject);
        }
    }
}
