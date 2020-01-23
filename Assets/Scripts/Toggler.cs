using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggler : MonoBehaviour
{
   private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "GargulecParent")
        {
            //collider.gameObject.GetComponent<Rigidbody>().useGravity = false;
            //collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            //collider.gameObject.GetComponent<Rigidbody>().velocity = 0f;
            gameObject.SetActive(false);
        }
    }
}
