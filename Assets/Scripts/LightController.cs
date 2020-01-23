using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public GameObject flyingObject, notFlyingObject;
    public GameObject calibrator;
    void Start()
    {
       // rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Frame.LightEstimate.PixelIntensity < calibrator.GetComponent<CalibrateLightEstimation>().avgVal*0.9)
        {
            flyingObject.SetActive(false);
            notFlyingObject.SetActive(true);
        }
        else
        {
           
            flyingObject.SetActive(true);
            notFlyingObject.SetActive(false);
        }
    }
}
