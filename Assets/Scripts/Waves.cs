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
    public GameObject WaveHolder2;
    public GameObject WaveHolder3;
    public GameObject WaveHolder4;
    public GameObject WaveHolder5;
    public bool Wave2done;
    public bool wave3done;
    public bool wave4done;
    public bool wave5done;
    public void Start()
    {
        instance = this;
        Wave2done = false;
        wave3done = false;
    }

    public void AddKillcount()
    {
    }
    public void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            Debug.Log("Wave 1 Finishied");
            StartCoroutine(Wave2());

            if (Wave2done == true)
            {
                StartCoroutine(Wave3());
            }
            if (wave3done == true)
            {
                StartCoroutine(Wave4());
            }
            if (wave4done == true)
            {
                StartCoroutine(Wave5());
            }
        }

        if(Wave2done == true)
        {
            ScoreManager.instance.AddCurrentWave();
            Wave2done = false;
        }
        if (wave3done == true)
        {
            ScoreManager.instance.AddCurrentWave3();
            wave3done = false;
        }
        if (wave4done == true)
        {
            ScoreManager.instance.AddCurrentWave4();
            wave4done = false;
        }
        if (wave5done == true)
        {
            ScoreManager.instance.AddCurrentWave4();
            wave5done = false;
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
        wave3done = true;
    }
    public IEnumerator Wave4()
    {
        Debug.Log("Wave 4 started");
        WaveText.SetActive(true);
        yield return new WaitForSeconds(3);
        WaveText.SetActive(false);
        yield return new WaitForSeconds(1);
        WaveHolder4.SetActive(true);
        wave4done = true;
    }
    public IEnumerator Wave5()
    {
        Debug.Log("Wave 5 started");
        WaveText.SetActive(true);
        yield return new WaitForSeconds(3);
        WaveText.SetActive(false);
        yield return new WaitForSeconds(1);
        WaveHolder5.SetActive(true);
        wave5done = true;
    }
}
