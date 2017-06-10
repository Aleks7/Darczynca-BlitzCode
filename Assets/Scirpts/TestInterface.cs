using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public class TestInterface : MonoBehaviour 
{
    public static bool Klikajka;
    private bool aaa;
	private string note;
    private static List<string> Link = new List<string>();
    private int organizations;
    void Start () 
	{
        FillList();
		WebMediator.Install();
	}
	
	void Update () 
	{
	    if (WebMediator.IsVisible()) 
		{            
	        ProcessMessages();
	    }
        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            DeactivateWebView();
            aaa = false;
            StartCoroutine(klikacz());
        }
        if (Input.GetButtonDown("Fire1") && Input.mousePosition.y > Screen.height / 8 + 12) 
		{
            DeactivateWebView();
            aaa = false;
            StartCoroutine(klikacz());
        }
    }
	
	public void ActivateWebView() 
	{
        Klikajka = true;
        aaa = true;
        Int32.TryParse(EventSystem.current.currentSelectedGameObject.name, out organizations);
	    WebMediator.LoadUrl(Link[organizations]);
	    WebMediator.SetMargin(12, Screen.height / 8 + 12, 12, 12);
	    WebMediator.Show();
	}
	
	private void DeactivateWebView() 
	{
	    WebMediator.Hide();
	    WebMediator.LoadUrl("about:blank");
	}
	
	private void ProcessMessages() 
	{
	    while (true) 
		{
	        WebMediator.WebMediatorMessage message = WebMediator.PollMessage();
	        if (message == null) break;
	    }
	}	
    
    private void FillList()
    {
        Link.Add("http://www.pajacyk.pl/");
        Link.Add("http://www.okruszek.org.pl/");
        Link.Add("http://www.pmiska.pl/");
        Link.Add("http://kociklik.pl/");
        Link.Add("http://www.dobryklik.pl/");
    }

    IEnumerator klikacz()
    {
        yield return new WaitForSeconds(5);
        if (aaa == false)
        {
            Klikajka = false;
        }        
    }

}
