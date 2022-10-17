using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    // the varible for the speed and the directions they move and also so you can change the speed of the monster in unity
    [SerializeField, Range(1, 10)]
    private float speed = 10;
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 y = new Vector3(0, -0.3f, 0);
   
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame-
    void Update()
    {
        //makes the object move right 
        transform.position += speed * direction * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when this object collides with the tag "Wall" it changes direction 
        if (collision.transform.tag == "Wall") 
        {
            direction.x = -direction.x;
            transform.position += y;
        }
        // if it Collides with the object that has the tag fire it destroys itself and runs the "AddPoint"
        else if(collision.transform.tag == "Fire")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
        


    }

}
