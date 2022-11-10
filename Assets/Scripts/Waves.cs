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
    public GameObject WaveText;
    public int KillCount;

   public void Start()
    {
        instance = this;
    }

    public void AddKillcount()
    {
        KillCount++;
    }
    public void Update()
    {
        if(KillCount == 4)
        {
            ActiveWave2.instance.SetActiveWave();
        }


    }

}
