using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VPmanage : MonoBehaviour {

    private void Start()
    {
        if(PlayerPrefs.GetFloat("verticalPosition") != 0)
        {
            GetComponent<ScrollRect>().verticalNormalizedPosition = PlayerPrefs.GetFloat("verticalPosition");
        }
    }
}
