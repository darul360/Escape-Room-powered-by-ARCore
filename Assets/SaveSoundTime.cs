using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSoundTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StreamWriter writer = new StreamWriter("Asasdds.txt", true);
        writer.WriteLine(gameObject.GetComponent<AudioSource>().time);
        writer.Close();
        string path = Application.persistentDataPath;
        File.WriteAllText(path + "/Testest.txt", gameObject.GetComponent<AudioSource>().time.ToString());
    }
}
