﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainInterface : MonoBehaviour
{
    public Button TowerListOpenButton;
    // Start is called before the first frame update
    void Start()
    {
        TowerListOpenButton.onClick.AddListener(this.ShowTowerList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowTowerList()
    {
        UILoader.instance.Load("Assets/TowerDefense/Prefabs/UI/TowerListPopup.prefab");
    }
}
