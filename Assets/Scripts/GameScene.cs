using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class Root : MonoBehaviour
{
    private GComponent mainView;
    // Start is called before the first frame update
    void Start()
    {
        GRoot root = GRoot.inst;
        UIPackage.AddPackage("UI/Login");
        mainView = UIPackage.CreateObject("Login", "LoginView").asCom;
        mainView.name = "LoginView";
        root.AddChild(mainView);
    }

    void OnDestroy()
    {
        if (mainView != null)
        {
            GRoot.inst.RemoveChild(mainView);
            mainView.Dispose();
        }
        UIPackage.RemovePackage("UI/Login");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
