using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[RequireComponent(typeof(VoiceController))]
public class VoiceTest : MonoBehaviour
{

    public Text uiText;

    VoiceController voiceController;

    public void GetSpeech()
    {
        voiceController.GetSpeech();
    }

    void Start()
    {
        voiceController = GetComponent<VoiceController>();
    }

    void OnEnable()
    {
        VoiceController.resultRecieved += OnVoiceResult;
    }

    void OnDisable()
    {
        VoiceController.resultRecieved -= OnVoiceResult;
    }

    void OnVoiceResult(string text)
    {
        uiText.text = text;

    }
}
