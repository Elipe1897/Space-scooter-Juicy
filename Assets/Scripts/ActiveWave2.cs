using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWave2 : MonoBehaviour
{
    public static ActiveWave2 instance;

    void Start()
    {
        instance = this;
    }

    public void SetActiveWave()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
