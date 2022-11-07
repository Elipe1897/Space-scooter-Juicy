using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;
public class Waves : MonoBehaviour
{
    public static Waves instance;

    [SerializeField]
    public GameObject MonsterSmall;

    [SerializeField]
    public GameObject MonsterBig;

    [SerializeField]
   public GameObject MonsterBoss;

    [SerializeField]
    public GameObject WaveText;

    [SerializeField]
    public int KillCount;

    public float timer;
    public bool TimerCheck;
    public bool WaveTextCheck;
    void Start()
    {
        instance = this;
        Wave1();
        timer = 0;
        TimerCheck = false;
        WaveTextCheck = false;
    }

    public void AddKillcount()
    {
        KillCount++;
    }
    public void Wave1()
    {
        Instantiate(MonsterSmall, transform.position + new Vector3(-3.66f, 4.3f, 1), Quaternion.identity);
        Instantiate(MonsterSmall, transform.position + new Vector3(-1.17f, 4.3f, 1), Quaternion.identity);
        Instantiate(MonsterSmall, transform.position + new Vector3(1.04f, 4.3f, 1), Quaternion.identity);
        Instantiate(MonsterSmall, transform.position + new Vector3(3.39f, 4.3f, 1), Quaternion.identity);
    }
    public void Wave1End()
    {
        TimerCheck = true;
        if(timer > 5)
        {
            timer = 0;
            Wave2();
            TimerCheck = false;
            KillCount = 0;
        }
        
    }
    public void Wave2()
    {
        Instantiate(MonsterSmall, transform.position + new Vector3(-2.77f, 3.8f, 1), Quaternion.identity);
        Instantiate(MonsterSmall, transform.position + new Vector3(0f, 3.8f, 1), Quaternion.identity);
        Instantiate(MonsterSmall, transform.position + new Vector3(2.77f, 3.8f, 1), Quaternion.identity);
        Instantiate(MonsterBig, transform.position + new Vector3(0, 4.6f, 1), Quaternion.identity);
    }

    void Update()
    {
        if(KillCount == 4)
        {
            Wave1End();
            WaveTextCheck = true;
            Debug.Log("nu blir de true");
        }
        if (WaveTextCheck == true)
        {
            Instantiate(WaveText, transform.position + new Vector3(0, 0, 1), Quaternion.identity);
            WaveTextCheck = false;
        }
        if (TimerCheck == true)
        {
            timer += Time.deltaTime;
        }
    }
}
