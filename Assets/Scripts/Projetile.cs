using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetile : MonoBehaviour
{
    int[] colors = new int[5];
    [SerializeField]
    public GameObject BulletExplosionEffect;

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        transform.position += new Vector3(0, 15, 0) * Time.deltaTime; // makes the shot travel upwards 
    }


    public void OnCollisionEnter2D(Collision2D collision) // Destroy the projetile when it hits one of theese tags
    {
        if (collision.transform.tag == "EnemyFire" || collision.transform.tag == "Sheild" || collision.transform.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Enemy")
        {
            CameraShake.instance.ShakeTrue();
            ScoreManager.instance.AddPoint(10);
            Waves.instance.AddKillcount();
        }
        if (collision.transform.tag == "EnemyBig")
        {
            ScoreManager.instance.AddPoint(20);
            Waves.instance.AddKillcount();
        }
        if (collision.transform.tag == "EnemyBoss")
        {
            ScoreManager.instance.AddPoint(50);
            Waves.instance.AddKillcount();
        }

        if (collision.transform.tag == "EnemyFire")
        {

        }

    }
}
