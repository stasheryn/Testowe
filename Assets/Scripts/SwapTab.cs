using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTab : MonoBehaviour
{
    public void OpenTab(int tabNumb)
    {
        //Debug.Log("Tab " + (tabNumb + 1) + " is Active, other is not");

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(tabNumb).gameObject.SetActive(true);
    }
    
}