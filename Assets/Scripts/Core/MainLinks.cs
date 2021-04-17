using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLinks : MonoBehaviour
{
    public static MainLinks Instance;

    public UITextWriter TextWriter { get; set; }
    public RayProvider RayProvider { get; set; }
    public SceneChanger SceneChanger { get; set; }

    void Awake()
    {   
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Debug.LogError("There are more then 1 MainLinks's Instance");
    }
}
