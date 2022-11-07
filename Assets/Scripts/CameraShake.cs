using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    public Vector2 freq;
    [SerializeField]
    public Vector2 amp;

    Vector2 time;

    [SerializeField]
    bool ShouldShake;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += freq * Time.deltaTime;
        Vector3 ShakePos = transform.localPosition;

        if (ShouldShake)
        {
            ShakePos.x = Mathf.Sin(time.x) * amp.x;
            ShakePos.y = Mathf.Sin(time.y) * amp.y;
        }
        else
        {
            ShakePos = Vector3.zero;
        }

        transform.localPosition = ShakePos;

    }
}
