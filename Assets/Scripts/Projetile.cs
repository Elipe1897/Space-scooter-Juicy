using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 5, 0) * Time.deltaTime; // makes the shot travel upwards 
    }

  
    private void OnCollisionEnter2D(Collision2D collision) // Destroythe projetile when it hits one of theese tags
    {
        if (collision.transform.tag == "child" || collision.transform.tag == "Father" ||
            collision.transform.tag == "EnemyFire" || collision.transform.tag == "Sheild")
        {
            Destroy(gameObject);
        }
       
    }
}
