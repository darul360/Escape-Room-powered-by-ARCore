using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class CameraToggleON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
		{
			Permission.RequestUserPermission(Permission.Camera);
            Debug.Log("Permission Granted");
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
