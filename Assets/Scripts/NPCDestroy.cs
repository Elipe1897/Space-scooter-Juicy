using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem ExplosionEffect;
    public ParticleSystem ExplosionEffectDeath;
    public int AlienLives;

    // the varible for the speed and the directions they move and also so you can change the speed of the monster in unity
    [SerializeField, Range(1, 10)]
    private float speed = 2;

    [SerializeField]
    GameObject projectiles;

    private Vector3 direction = new Vector3(1, 0, 0);

    private Vector3 y = new Vector3(0, -1f, 0);

    public float timer;

    // Start is called before the first frame update
    public void Start()
    {
        timer = 0;
    }
    // Update is called once per frame-
    public void Update()
    {
        //makes the object move right 
        transform.position += speed * direction * Time.deltaTime;

        timer += Time.deltaTime;

        if (timer > 3)// checks if it has gone more than 3 second
        {
            //Creates a bullet from the monster and fires downwards
            Instantiate(projectiles, transform.position + new Vector3(0, -1.2f, 0), Quaternion.identity);
            transform.position += new Vector3(0, 0, 0) * Time.deltaTime;
            timer = 0;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // when this object collides with the tag "Wall" it changes direction 
        if (collision.transform.tag == "Wall")
        {
            direction.x = -direction.x;
            transform.position += y;
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        }
        // if it Collides with the object that has the tag fire it destroys itself and runs the "AddPoint"
        else if (collision.transform.tag == "Fire")
        {
            Instantiate(ExplosionEffectDeath, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }



    }

}
