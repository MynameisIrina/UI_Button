using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    private int value = 0;
    private bool pressed;
    private bool unpressed;
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    { 
        /*
        *  increase 'value' variable and make it a string to be able to display it on the screen
        */
        if (pressed)
        {
            ++value;
            counter.text = value.ToString();
        }
        
    }
    

    public void IncreaseCounter()
    {
        /*
        *  + alternate 'pressed' variable to be able to stop and continue counting
        *  + play sound when button is clicked
        */
        clickSound.Play();
        pressed = !pressed;
    }


    // background taken from https://www.freepik.com/free-photos-vectors/smooth-background
    
    
}
