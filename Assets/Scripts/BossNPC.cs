using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossNPC : MonoBehaviour
{
    //Sets the at 10 and you can change the speed in unity - Elias
    [SerializeField, Range(1, 15)]
    private float speed = 10;
    //The speed of how fast it moves to the side and downwards - Elias
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 y = new Vector3(0, -0.2f, 0);
    //variables for if the boss hasMoved and set the score to 0  - Elias
    public bool Boss, hasMoved;
    int score = 0;
    //variable for the timer set to 0 and also a variable for player and so you can change the player in unity - Elias
    [SerializeField]
    private GameObject Player;
    float timer = 0;
    // Start is called before the first frame update
    public void Start()
    {
        //sets boss to false and hasMoved to false from the beginning - Elias
        Boss = false;
        hasMoved = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if(timer > 2) // checks if it has gone more than 2 seconds - Elias
        {
            // creats a bullet if it has gone more than 2 seconds - Elias
            timer = 0;
            transform.position += new Vector3(0, 0, 0) * Time.deltaTime;
            Instantiate(Player, transform.position + new Vector3(0, -1.2f, 0), Quaternion.identity);
        }
       
        if (ScoreManager.instance.score > 329) // if score is more than 185 points the boss apears  - Elias
        {
            Boss = true;
        }
        if (Boss == true && hasMoved == false) // if boss is true and hasMoved is false it moves the boss into the gamescene - Elias
        {
            transform.position = new Vector3(-1.4f, 4.38f, 1);
            hasMoved = true; 
        }
        transform.position += speed * direction * Time.deltaTime; // makes the boss move  - Elias
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Wall") // if it collides with the tag wall it moves down a bit and changes directions back - Elias
        {
            direction.x = -direction.x;
            transform.position += y;

        }
        else if (collision.transform.tag == "Fire") // if it collides the tag Fire it destroys itself - Elias
        {
            Destroy(gameObject);
        }
       if(collision.transform.tag == "Fire" == true) // if it collides the tag Fire it loads the victory scene  - Elias
        {
            SceneManager.LoadScene("Victory");
        }

    }
}
