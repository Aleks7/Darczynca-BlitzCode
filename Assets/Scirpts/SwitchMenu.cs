using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchMenu : MonoBehaviour
{

    public Button sms;
    public Button darmowe;
    public GameObject menuSMS;
    public GameObject menuDarmowe;
    // Use this for initialization
    void Start()
    {
        sms.image.color = new Color(1, 1, 1);
        darmowe.image.color = new Color(0.5f, 0.5f, 0.5f);
        sms.image.rectTransform.sizeDelta = new Vector2(360, 120);
        darmowe.image.rectTransform.sizeDelta = new Vector2(360, 100);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void switchmenuSMS()
    {
        sms.image.color = new Color(1,1,1);
        darmowe.image.color = new Color(0.5f, 0.5f, 0.5f);
        sms.image.rectTransform.sizeDelta = new Vector2(360, 120);
        darmowe.image.rectTransform.sizeDelta = new Vector2(360, 100);
        menuSMS.SetActive(true);
        menuDarmowe.SetActive(false);
    }
    public void switchmenuDarmowe()
    {
        sms.image.color = new Color(0.5f, 0.5f, 0.5f);
        darmowe.image.color = new Color(1, 1, 1);
        sms.image.rectTransform.sizeDelta = new Vector2(360, 100);
        darmowe.image.rectTransform.sizeDelta = new Vector2(360, 120);
        menuSMS.SetActive(false);
        menuDarmowe.SetActive(true);
    }
}