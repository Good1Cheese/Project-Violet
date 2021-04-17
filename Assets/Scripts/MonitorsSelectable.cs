using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorsSelectable : MonoBehaviour, ISelectable
{
    const int screenPartIndex = 3;
    [SerializeField] Color highLightColor;
    [SerializeField] Color defaultColor;
    Renderer renderer;
    Material[] materials;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        materials = renderer.materials;

    }

    public void Deselect()
    {
        materials[screenPartIndex].color = defaultColor;
    }

    public void Select()
    {
        materials[screenPartIndex].color = highLightColor;
    }

}
