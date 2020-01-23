using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SwapModels : MonoBehaviour
{
    public GameObject gargParent;
    public GameObject button,image,voiceController;
    public Text textDonor;
    public GameObject buttonCalib,Calibrator;

    void Update()
    {
        if (textDonor.text == "hello")
        {
            gargParent.SetActive(true);
            Destroy(voiceController);
            Destroy(button);
            Destroy(image);
            buttonCalib.SetActive(true);
        }
    }

    /*IEnumerator MyMethod()
    {
        Color buttonColor = button.GetComponent<Button>().GetComponent<Image>().color;
        button.GetComponent<Button>().GetComponent<Image>().color = new Color(buttonColor.r, buttonColor.g, buttonColor.b, 0.8f);
        yield return new WaitForSeconds(0.2f);
        button.GetComponent<Button>().GetComponent<Image>().color = new Color(buttonColor.r, buttonColor.g, buttonColor.b, 0.6f);
        yield return new WaitForSeconds(0.2f);
        button.GetComponent<Button>().GetComponent<Image>().color = new Color(buttonColor.r, buttonColor.g, buttonColor.b, 0.4f);
        yield return new WaitForSeconds(0.2f);
        button.GetComponent<Button>().GetComponent<Image>().color = new Color(buttonColor.r, buttonColor.g, buttonColor.b, 0.2f);
        yield return new WaitForSeconds(0.2f);
        button.GetComponent<Button>().GetComponent<Image>().color = new Color(buttonColor.r, buttonColor.g, buttonColor.b, 0f);
    }*/
}
