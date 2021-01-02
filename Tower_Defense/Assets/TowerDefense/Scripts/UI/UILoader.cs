﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class UILoader
{
    private static UILoader instance;
    public static UILoader Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new UILoader();
            }
            return instance;
        }
    }
    private Dictionary<string, GameObject> UIObjectDictionary = new Dictionary<string, GameObject>();
    public GameObject Load(string path)
    {
        GameObject obj;
        if (this.UIObjectDictionary.TryGetValue(path, out obj) == false)
        {
            obj = UnityEngine.Object.Instantiate<GameObject>(UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(path));
            if (obj != null)
                UIObjectDictionary.Add(path, obj);
            else
                Debug.LogErrorFormat("Load Fail at Path {0}", path);
        }
        else
            Debug.LogErrorFormat("Already Loaded {0}", path);

        return obj;
    }
    public void Unload(GameObject obj)
    {
        if (obj == null)
            return;

        if (this.UIObjectDictionary.ContainsValue(obj) == false)
        {
            Debug.LogErrorFormat("NotExist {0}", obj.name);
            return;
        }

        var removePair = this.UIObjectDictionary.Where(pair => pair.Value.Equals(obj)).First();
        GameObject.Destroy(removePair.Value);
        this.UIObjectDictionary.Remove(removePair.Key);
    }
}
