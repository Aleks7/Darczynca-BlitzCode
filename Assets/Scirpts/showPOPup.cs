using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showPOPup : MonoBehaviour {

    public GameObject mySecondCanvas;
    public bool sendSMSBlock = false;
    bool warningLock = false;
    public GameObject warning;
    public void ShowPopUp()
    {
        if (!sendSMSBlock)
        {
            mySecondCanvas.SetActive(true);
            StartCoroutine(smsSendingLock());
        }
        else
        {         
            warning.SetActive(true);       
        }
    }
	
	IEnumerator smsSendingLock()
    {
        yield return new  WaitForSeconds(10);
        sendSMSBlock = false;
    }

    
}
