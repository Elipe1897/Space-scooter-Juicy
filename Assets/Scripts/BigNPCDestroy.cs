using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigNPCDestroy : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem ExplosionEffect;
    public ParticleSystem ExplosionEffectDeath;
    public int AlienLives;

    //So you can change the speed in unity and a variable for the speed 
    [SerializeField, Range(1, 10)]
    private float speed = 10;

    //changes the direction of the monster 
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 y = new Vector3(0, -0.8f, 0);

    [SerializeField]
    private GameObject Monster;

    // so you can change the player in unity and a variable for the timer
    [SerializeField]
    private GameObject Player;
    float timer = 0;

    // Start is called before the first frame update
    public void Start()
    {
        AlienLives = 2;
    }
    // Update is called once per frame
    public void Update()
    {
        timer += Time.deltaTime;
        if (AlienLives == 0)
        {
            Destroy(gameObject);
        }

        if (timer > 3)// checks if it has gone more than 3 second
        {
            //Creates a bullet from the monster and fires downwards
            timer = 0;
            transform.position += new Vector3(0, 0, 0) * Time.deltaTime;
            Instantiate(Player, transform.position + new Vector3(0, -1.2f, 0), Quaternion.identity);
        }

        transform.position += speed * direction * Time.deltaTime;//Makes the bullet move
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Wall")// if it collides with the tag Wall it changes direction
        {
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            direction.x = -direction.x;
            transform.position += y;
        }
        else if (collision.transform.tag == "Fire")
        {
            Instantiate(ExplosionEffectDeath, transform.position, Quaternion.identity);
            AlienLives--;
        }

    }
}
