
using UnityEngine;
using UnityEngine.UI; 
using System.Collections;
using TMPro;
using System;
using UnityEngine.SocialPlatforms.Impl;
using RTLTMPro;
using UnityEngine.Localization.Settings;

public class Main : MonoBehaviour
{

    [SerializeField] Button resetBtn;
    [SerializeField] GameObject title;


    private LocalizationGroup titleTexts;

    // Start is called before the first frame update
    void Start()
    {
        titleTexts = title.GetComponent<LocalizationGroup>();   
        resetBtn.onClick.AddListener(ResetGame);

    }
   
    
        void Update()
    {
       
    }

    void ResetGame()
    {
       
    }

   


}