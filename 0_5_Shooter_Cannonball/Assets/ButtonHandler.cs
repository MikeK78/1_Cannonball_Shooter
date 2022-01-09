using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{

    public ProgressBar MyProgressbar;

   public void FillUp()
    {
        if(this.name == "up")
        {
            MyProgressbar.FillUp();
        }
        else
        {
            MyProgressbar.FillDown();
        }
        
    }
}
