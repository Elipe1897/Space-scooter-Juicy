using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { Spawning, Waitning, Counting }; //Defining enumurator "SpawnState" that has "Spawning, Waitning, Counting" in it - Leo N

    [System.Serializable] //Allows me to change things in the unity editor - Leo N
    public class Wave //creating a class "Wave", Defining what wave is essentialy - Leo N
    {
        public string Name; //Name for the wave - Leo N
        public Transform Enemy; //Variable for enemy - Leo N
        public int Amount; // Variable for the amount of enemies spawning - Leo N
        public float Rate; //Variable for the spawn rate of enemies - Leo N
    }

    public Wave[] Waves; //Making an array called "Waves" for the diffrent waves - Leo N
    private int NextWave = 0; //Variable for the index of what wave that is next - Leo N

    public float TimeBetweenWaves = 5; //Variable that keeps the time betewen the diffrent waves, set to 5 seconds by default - Leo N
    public float WaveCountDown; //Variable for the countdown beetween the waves, set to 0 by default - Leo N

    private SpawnState State = SpawnState.Counting; //Making a variable for the spawn state called "State" - Leo N

    private float SearchCountDown = 1; //Variable for the count down of search if enemies are alive - Leo N

    public void Start()
    {
       WaveCountDown = TimeBetweenWaves; //Making the Wave count down the same as the time beetwen waves - Leo N
    }
    public void Update()
    {
        WaveCountDown -= Time.deltaTime;
        if (State == SpawnState.Waitning) //Checking if enemies are still alive, if the spawning state is WAITNING then... - Leo N
        {
            if(!EnemyIsAlive()) //Calling the method "EnemyIsAlive" and checking if its not true - Leo N
            {
                //Begining a new round
                Debug.Log("Wave compleated !");
                return;
            }
            else
            {
                return; 
            }
        }

        if(WaveCountDown <= 0) //If waveCountDown is less or equal to 0, check if spawning has started - Leo N
        {
            if(State != SpawnState.Spawning)//If SpawnState is not equal to Spawning then the waves should start - Leo N
            {
                StartCoroutine(SpawnWave( Waves[NextWave] ) ); //Starting the spawning method - Leo N
            }
            else
            {
                WaveCountDown -= Time.deltaTime; //Makes it so that the time counts down correctly for each frame - Leo N
            }
        }
    }

    bool EnemyIsAlive() //Method to check if enemies are alive - Leo N
    {
        SearchCountDown -= Time.deltaTime;

        if (SearchCountDown <= 0) //If The search count down is less then or equal to 0 then... - Leo N
        {
            SearchCountDown = 1f; //sets the SearchCountDown to 1, so that it can check again in 1 seconds- Leo N
            if(GameObject.FindGameObjectWithTag("Enemy") == null) //If no gameobject with the tag "Enemy" are active then return the variable false - Leo N
             {

                 return false;
             }
        }
        return true; //If enemies are alive, returning the variable true - Leo N
    }

    IEnumerator SpawnWave (Wave _Wave)
    {
        Debug.Log("Spawning wave: " + _Wave.Name);
        State = SpawnState.Spawning;

        for(int i = 0; i < _Wave.Amount; i++) //Creating a for loop that runs the number of enemies that should spawn - Leo N
        {
            SpawnEnemy(_Wave.Enemy); //Calling the method SpawnEnemy - Leo N
            yield return new WaitForSeconds(1f / _Wave.Rate);

        }

        State = SpawnState.Waitning;


        yield break; //Ending the method with yield break so that the method returnes a value of nothing - Leo N
    }

    void SpawnEnemy (Transform _Enemy)
    {
        //Spawn Enemy
        Debug.Log("Spawning enemy" + _Enemy.name);
        Instantiate(_Enemy, transform.position, transform.rotation);
        
    }
       
}
