using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    // stars taken from href= "https://lovepik.com/images/png-cartoon-stars.html"
    [SerializeField] private Image star1;
    [SerializeField] private Image star2;

    // Start is called before the first frame update
    void Start()
    {
        /*
         * make star images invisible when application was run for the first time
         */
        star1.enabled = false;
        star2.enabled = false;
    }

    public void PlayAnimation()
    {
        /*
         * + play button animation when button is pressed
         * + make stars visible so the animation can be seen
         * + play stars animation
         */
        GetComponent<Animation>().Play("ButtonAnimation");
        star1.enabled = true;
        star2.enabled = true;
        star1.GetComponent<Animation>().Play("StarAnimation");
        star2.GetComponent<Animation>().Play("Star2Animation");
    }
    
}
