using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PizzaN;
public class request : MonoBehaviour
{
    private const double speed = 0.05;
    public double ad = 1;
    private double Progress;
    private double second = 1;
    private int requestCount = 0;
    public short MaxRequestCount = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;

        if (second <= 0)
        {
            Progress += speed * ad;
            second = 1;
        }
        if (Progress >= 1.0)
        {
            if (requestCount < MaxRequestCount)
            {
                requestCount += 1;
            }
            Progress = 0.0;
            Debug.Log(requestCount);
        }
    }
}