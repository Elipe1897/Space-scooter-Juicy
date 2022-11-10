using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFire : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem BulletExplosionEffect;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
     // Fires the bullet downwards 
        transform.position += new Vector3(0, -10, 0) * Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
      // when this objetcs collides with one of theese tag it destroys itself 
        if(collision.transform.tag == "Sheild" || collision.transform.tag == "SpaceShip" || collision.transform.tag == "Fire" || collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
            Instantiate(BulletExplosionEffect, transform.position, Quaternion.identity);
        }
    }
}
