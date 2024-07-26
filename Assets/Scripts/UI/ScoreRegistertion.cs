using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTLTMPro;
using TMPro;

public class ScoreRegistertion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI textForRegistration = GetComponent<TextMeshProUGUI>();
        EndGameManager.endManager.RegisterScoreText(textForRegistration);
        textForRegistration.text = "امتیاز: 0";
    }

    
}
