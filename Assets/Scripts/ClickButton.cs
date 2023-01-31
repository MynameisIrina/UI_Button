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
    [SerializeField] private Button button;
    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            ++value;
            counter.text = value.ToString();
        }
        
        
    }

    public void IncreaseCounter()
    {
        clickSound.Play();
        pressed = !pressed;
    }
    
    public int getValue()
    {
        return value;
    }
    
    
}
