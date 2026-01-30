using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Time Manager")]
    public float timeRemaining = 10f;
    public TMP_Text timerText;

    void Update()
    {
        ReducerTime();
    }

    public void ReducerTime()
    {
        
        timeRemaining -= Time.deltaTime;
        int intTime = Mathf.FloorToInt(timeRemaining);
        if (timerText != null)
        {
            timerText.text = intTime.ToString();
        }
        Debug.Log(intTime);
    }

   
}
