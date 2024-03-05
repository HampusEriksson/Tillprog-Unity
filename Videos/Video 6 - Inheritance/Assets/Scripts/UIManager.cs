using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI animalText;
    public TextMeshProUGUI tigerText;
    public TextMeshProUGUI timerText;

    private int tigercount;
    private int animalcount;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        tigercount = GameObject.FindGameObjectsWithTag("Tiger").Length;
        animalcount = GameObject.FindGameObjectsWithTag("Deer").Length + GameObject.FindGameObjectsWithTag("Chicken").Length;

        tigerText.text = "Tigers: " + tigercount;
        animalText.text = "Animals: " + animalcount;

        if (animalcount != 0)
        {
            timer += Time.deltaTime;
        }


        timerText.text = (Mathf.Round(timer * 100.0f) * 0.01f).ToString() + " s";

    }
}
