using TMPro;
using UnityEngine;

public class TEst : MonoBehaviour
{
    public TextMeshProUGUI text;

    float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        int seconds = Mathf.FloorToInt(time); // 초
        int milliseconds = Mathf.FloorToInt((time - Mathf.Floor(time)) * 100); // 밀리초

        text.text = string.Format("{0:000}:{1:00}", seconds, milliseconds);
    }
}
