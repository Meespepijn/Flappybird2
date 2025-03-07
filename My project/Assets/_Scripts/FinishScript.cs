using UnityEngine;
using TMPro;

public class FinishScript : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Congrats!");
        TimeScript timer = FindObjectOfType<TimeScript>();
        if (timer != null)
        {
            timer.StopTimer();
        }
    }


}
