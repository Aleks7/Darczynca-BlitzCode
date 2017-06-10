using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

    public static string org;
    public ScrollRect scroll;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && TestInterface.Klikajka == false)
        {
            Application.Quit();
        }
    }

    public void organizationName()
    {
        PlayerPrefs.SetFloat("verticalPosition", scroll.verticalNormalizedPosition);
        org = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene("PaySMS");
    }
}
