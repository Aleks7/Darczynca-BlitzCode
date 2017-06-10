using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SendSMS : MonoBehaviour {

    public string message;
    public static int sizeOflist;
    public GameObject popupCanvas;
    AndroidJavaObject currentActivity;
    public GameObject showPOPUP;
    public GameObject warning;
    public void Yes(string m)
    {
        Send(m);
        popupCanvas.SetActive(false);
        showPOPup showP = showPOPUP.GetComponent<showPOPup>();
        showP.sendSMSBlock = true;
    }
    public void No()
    {
        popupCanvas.SetActive(false);
    }
    public void Ok()
    {
        warning.SetActive(false);
    }

    public void Send(string o)
    {        
        message = o;
        if (Application.platform == RuntimePlatform.Android)
        {
            RunAndroidUiThread();
        }
    }

    void RunAndroidUiThread()
    {
        AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(SendProcess));
    }

    void SendProcess()
    {
        Debug.Log("Running on UI thread");
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");

        // SMS Information

        char split = ';';
        string[] substrings = message.Split(split);
        string phone = substrings[0]; // "+48790764084";
        string text = substrings[1]; // "Dupa";
        string alert;

        try
        {
            // SMS Manager

            AndroidJavaClass SMSManagerClass = new AndroidJavaClass("android.telephony.SmsManager");
            AndroidJavaObject SMSManagerObject = SMSManagerClass.CallStatic<AndroidJavaObject>("getDefault");
            SMSManagerObject.Call("sendTextMessage", phone, null, text, null, null);

            alert = "Wiadomość wysłana pomyślnie.";
        }
        catch (System.Exception e)
        {
            Debug.Log("Error : " + e.StackTrace.ToString());

            alert = "Nie udało się wysłać wiadomosći.";
        }

        // Wyświetlić alert

        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", alert);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
        toast.Call("show");
    }
}
