using System.Collections;
using System.Collections.Generic;
using GoogleARCore;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public Camera camera;
    private bool holding;

    void Start()
    {
        holding = false;
    }

    void Update()
    {

       

        // One finger
        if (Input.touchCount == 1)
        {

            // Tap on Object
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f))
                {
                    Debug.Log(hit.collider.name);
                    holding = true;
                }
            }

            // Release
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                holding = false;
            }
        }
    }

  
}

