using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variables for diffrent waves, all are in seralize fields so that i can put what enemies i want in the unity editor, also created arrays so that i can choose how many enemies and which enemy - Leo N
    [SerializeField] 
    GameObject[] _Wave1;

    [SerializeField] 
    GameObject[] _Wave2;

    [SerializeField]
    GameObject[] _Wave3;

    [SerializeField]
    GameObject[] _Wave4;

    [SerializeField]
    GameObject[] _EnemyPrefabs;

    public int CurrentWave = 1; //Variable for the current wave, the number indicating what wave is on - Leo N

    public bool StopSpawning = true; //Variable to set if spawning should happen or not - Leo N

    public GameObject enemy;

    void Start()
    {
        SpawnWaves();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnWaves()
    {
        while(StopSpawning == false)
        {
            switch(CurrentWave)
            {
                case 1:
                    CurrentWave++;
                    foreach(GameObject enemy in _Wave1)
                    {
                        spawnenemy();
                    }
                    break;
                case 2:
                    CurrentWave++;
                    foreach(GameObject enemy in _Wave2)
                    {
                        spawnenemy();
                    }
                    break;
                case 3:
                    CurrentWave++;
                    foreach(GameObject enemy in _Wave3)
                    {
                        spawnenemy();
                    }
                    break;
                case 4:
                    CurrentWave++;
                    foreach(GameObject enemy in _Wave4)
                    {
                        spawnenemy();
                    }
                    break;
                default:
                    Debug.Log("No waves left!");
                    break;
            }
            yield return new WaitForSeconds(10);

        }
    }

    public void spawnenemy()
    {
       // EnemyPrefabs = Random.Range(0, _EnemyPrefabs.Length);
       // float RandomXPostion = Random.Range(-10, -10);
      //  spawnposition = new Vector3(RandomXPostion, 8.5f, 1);
       // GameObject NewEnemy = Instantiate(_EnemyPrefabs[RandomEnemyPrefab], Spawnposition, Quaternion.identity);
      //  NewEnemy.transform.parent = enemycontainer.transform;
    }
}
