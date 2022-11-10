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
    public GameObject WaveHolder2;
    public GameObject WaveHolder3;
    public bool Wave2done;
    public void Start()
    {
        instance = this;
        Wave2done = false;
    }

    public void AddKillcount()
    {
        KillCount++;
    }
    public void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            Debug.Log("Wave 1 Finishied");
            StartCoroutine(Wave2());

            if(Wave2done == true)
            {
                StartCoroutine(Wave3());
            }


        }

    }

    public IEnumerator Wave2()
    {
        Debug.Log("Wave 2 started");
        WaveText.SetActive(true);
        yield return new WaitForSeconds(3);
        WaveText.SetActive(false);
        yield return new WaitForSeconds(1);
        WaveHolder2.SetActive(true);
        Wave2done = true;
    }

    public IEnumerator Wave3()
    {
        Debug.Log("Wave 3 started");
        WaveText.SetActive(true);
        yield return new WaitForSeconds(3);
        WaveText.SetActive(false);
        yield return new WaitForSeconds(1);
        WaveHolder3.SetActive(true);
    }
}
