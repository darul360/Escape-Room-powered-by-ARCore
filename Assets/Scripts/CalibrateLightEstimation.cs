using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GoogleARCore;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CalibrateLightEstimation : MonoBehaviour
{
    public float avgVal;
    private List<float> values = new List<float>();
    public GameObject button, button1, image;
    public bool flag = false,change = false;
    public GameObject gargoyle,gargoyle2;
    public Material finalMat;
    public Text text;
    public GameObject button2, image2;
    public GameObject suggestion;

    public void turnOnCalibButton()
    {
        Destroy(suggestion);
        button.SetActive(true);
    }

    public void StartCalibration()
    {
        StartCoroutine(Calibrate());

    }
    private void Update()
    {

        if (flag)
        {
            if(Frame.LightEstimate.PixelIntensity < 1.1 * avgVal)
            {
                gargoyle.SetActive(false);
                gargoyle2.SetActive(true);
                text.text = gargoyle.activeSelf.ToString() + " " + gargoyle2.activeSelf.ToString();
                button2.SetActive(true);
                image2.SetActive(true);

            }
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Detect");
    }
    IEnumerator Calibrate()
	{
		float timePassed = 0;
		while (timePassed < 5)
		{
            values.Add(Frame.LightEstimate.PixelIntensity);
            timePassed += Time.deltaTime;

			yield return null;
		}
        Destroy(button);
        calcAVG();
        

	}

    private void calcAVG()
    {
        avgVal = 0;
        foreach(float x in values)
        {
            avgVal += x;
        }

        avgVal /= values.Count();
        flag = true;
        StopAllCoroutines();
    }
}
