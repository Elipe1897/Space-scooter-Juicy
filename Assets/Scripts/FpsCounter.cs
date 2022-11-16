using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    public TextMeshProUGUI FpsText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;
    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int framerate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = framerate.ToString() + " Fps";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}