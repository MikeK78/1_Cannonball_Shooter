using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    public int minimum;
    public int maximum;
    public int startvalue;
    public float current;
    public Image mask;
    //public int steps;
    public int speed;


    //float currentOffset;
    //float maximumOffset;


    void Update()
    {
        SetCurrentFill();
    }

    void SetCurrentFill()
    {

        //currentOffset = current - minimum;
        //maximumOffset = maximum - minimum;
        float fillAmount = current / maximum;
        if (fillAmount < maximum)
        {
            mask.fillAmount = fillAmount;
        }
    }

    public void FillUp()
    {
        float MyNewCurrent = current + (speed * Time.deltaTime);
        if (MyNewCurrent <= maximum)
        {
            current += speed * Time.deltaTime;
        }
        
    }

    public void FillDown()
    {
        float MyNewCurrent = current - (speed * Time.deltaTime);
        if (MyNewCurrent >= minimum)
        {
            current -= speed * Time.deltaTime;
        }
    }
}
