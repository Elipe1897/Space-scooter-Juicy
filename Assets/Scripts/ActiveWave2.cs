using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWave2 : MonoBehaviour
{
    public static ActiveWave2 instance;

    [SerializeField]
    public GameObject WaveText;
    public void Start()
    {
        instance = this;
    }

    public void SetActiveWave()
    {
        StartCoroutine(SetActive());
    }

    public IEnumerator SetActive()
    {
        Debug.Log("IS IT WORKING?");
        Instantiate(WaveText, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
        yield return new WaitForSeconds(3);
        Destroy(WaveText);
        yield return new WaitForSeconds(1);
        
        
    }
    void Update()
    {
        
    }
}
