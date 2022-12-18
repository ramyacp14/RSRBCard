using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class R : MonoBehaviour,IVirtualButtonEventHandler {

    public GameObject bcardgo;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName== "Button")
        {
            Debug.Log("Button is pressed");
            bcardgo.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button released");
        bcardgo.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        VirtualButtonBehaviour vb = GetComponentInChildren<VirtualButtonBehaviour>();
        vb.RegisterEventHandler(this);
        bcardgo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
