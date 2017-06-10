using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ListPosition : MonoBehaviour {

    public RectTransform listposition;
    public ScrollRect myScrollRect;
    public float posy;
	// Use this for initialization
	void Start () {
        RectTransform list = listposition.GetComponent<RectTransform>();
        list.localPosition = new Vector3(0, 300,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
