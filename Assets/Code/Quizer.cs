using System;
using UnityEditor;
using UnityEngine;

public class Quizer : MonoBehaviour
{
    public string BootlesInfoPath;

    public BottleInfo[] _bottles;

    void Start()
    {
        var allAssets = AssetDatabase.LoadAllAssetsAtPath(BootlesInfoPath);
        _bottles = Array.ConvertAll<object, BottleInfo>(allAssets, obj => (BottleInfo)obj);
    }