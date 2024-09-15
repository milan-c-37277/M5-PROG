using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class timer : MonoBehaviour
{
    public run runScript;
    public float tijd;
    public string timeRound;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tijd += Time.deltaTime;
        if (runScript.FirstRun == true)
        {
            timeRound = math.round(tijd).ToString();
            text.text = "00:" + timeRound;
            Debug.Log(tijd);
        }
        
    }
}
