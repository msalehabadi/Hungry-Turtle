using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTLTMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] RTLTextMeshPro timerText;
    [SerializeField] float remainingTime;

    private readonly char[] arabicNumerals = { '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩' };

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            remainingTime = 0; // Ensure remainingTime does not go below zero
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        string minutesStr = minutes.ToString("00");
        string secondsStr = seconds.ToString("00");

        string arabicMinutes = ConvertToArabicNumerals(minutesStr);
        string arabicSeconds = ConvertToArabicNumerals(secondsStr);

        timerText.text = $"{arabicMinutes}:{arabicSeconds}";
    }


    private string ConvertToArabicNumerals(string number)
    {
        char[] arabicChars = new char[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            if (char.IsDigit(number[i]))
            {
                arabicChars[i] = arabicNumerals[number[i] - '0'];
            }
            else
            {
                arabicChars[i] = number[i];
            }
        }
        return new string(arabicChars);
    }
}
