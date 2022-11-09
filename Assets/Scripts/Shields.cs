using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{ // varible for the speed of this object, so you can change the speed of the object in unity and the direction this obeject moves 
    [SerializeField, Range(1, 10)]
    private float speed = 10;
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 y = new Vector3(0, 0, 0);

    [SerializeField]
    public ParticleSystem ExplosionEffect;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
      transform.position += speed * direction * Time.deltaTime; // Adds speed to the shells objects 
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Wall") // if this object hits a obhect with the tag "Wall" it's direction will change with going back the same way
        {
            direction.x = -direction.x;
            transform.position += y;
            Instantiate(ExplosionEffect,transform.position, Quaternion.identity);
        }
        if(collision.transform.tag == "EnemyFire") // if this collision with an object with the tag "EnemyFire" this object will be destroyed
        {
            Destroy(gameObject);
        }

    }
}

