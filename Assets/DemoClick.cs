using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class DemoClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // LocNaviMapService.setAppKey("nqB6HPIU2C");
        Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener(OnClick);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick() {
        Debug.Log("Button Clicked");
        LocNaviWebSDKBridge.test();
    }
}
