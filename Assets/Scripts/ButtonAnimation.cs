using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    [SerializeField] private Image star1;
    [SerializeField] private Image star2;

    // Start is called before the first frame update
    void Start()
    {
        star1.enabled = false;
        star2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayAnimation()
    {
        GetComponent<Animation>().Play("ButtonAnimation");
        star1.enabled = true;
        star2.enabled = true;
        star1.GetComponent<Animation>().Play("StarAnimation");
        star2.GetComponent<Animation>().Play("Star2Animation");
        waitAnimation();

    }

    IEnumerator waitAnimation()
    {
        yield return new WaitForSeconds(1);
        star1.enabled = false;
        star2.enabled = false;
    }
}
