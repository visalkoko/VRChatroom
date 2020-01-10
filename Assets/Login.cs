﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField UsernameInput;
    public InputField PasswordInput;
    public Button LoginButton;
    void Start()
    {
        LoginButton.onClick.AddListener(() => {
          Main.Instance.Web.Login(UsernameInput.text, PasswordInput.text);
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
