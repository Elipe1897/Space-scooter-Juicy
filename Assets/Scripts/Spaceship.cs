using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    public static Spaceship instance;
    [SerializeField]
    public ParticleSystem PlayerDeathEffect;
    public ParticleSystem PlayerWallEffect;
    //variable för objetet som ska skapas
    [SerializeField]
    private GameObject cubeprefab;
    float timer = 0;
    //varible for how fast you can move the ship and so you can change the speed of it in unity
    [SerializeField, Range(1, 10)]
    private float speed = 4;
    // variables for moving left and right and so you can change which buttons you use in unity
    [SerializeField]
    private KeyCode Right;
    [SerializeField]
    private KeyCode Left;

    public bool BeginGame;
    public GameObject BeginGameText;


    // Start is called before the first frame upda
    public void Start()
    {
        instance = this;
        Time.timeScale = 0;
        BeginGameText.SetActive(true);
    }

    // Update is called once per frame
    public void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) || BeginGame == true)
        {
            Debug.Log("Game Begins!");
            BeginGameText.SetActive(false);
            Time.timeScale = 1;
            BeginGame = false;
        }
            

        {
            if (Input.GetKeyDown(KeyCode.Space) && timer > 0.5f) // checks if button space is pressed after 1 secoond or more and fire a shoot if so
            {
                Instantiate(cubeprefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                timer = 0;
            }
        }
        // makes it so the player can move laft and right with the A,D key and also the left and right arrows
        if (Input.GetKey(KeyCode.D) || Input.GetKey(Right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(Left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

    }

    public void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "EnemyFire") // when this object get hit by a object with the tag "EnemyFire" it destroys itself 
        {
            Instantiate(PlayerDeathEffect, transform.position, Quaternion.identity);
            ScoreManager.instance.RemoveLife();
            //Destroy(gameObject);
        }

        if (collision.transform.tag == "Wall")
        {
            Instantiate(PlayerWallEffect, transform.position, Quaternion.identity);

        }

    }

}
