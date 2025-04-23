using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeRemaining = 60;
    [SerializeField] GameEnding gameEnding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        } else
        {
            timeRemaining = 0;
            gameEnding.OutOfTime();
        }
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = "Time Remaining - " + string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
