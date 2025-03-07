using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer;
    private bool isRunning = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isRunning)
        {
            timer += Time.deltaTime;
            UpdateTimerUI();
        }

    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + timer.ToString("F2");  // Show 2 decimal places
    }

    public void StopTimer()
    {
        isRunning = false;
        Debug.Log("Timer Stopped!");
    }


}
