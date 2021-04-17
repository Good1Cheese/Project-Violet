using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveItemsSelectable : MonoBehaviour, ISelectable
{
    [SerializeField] int highlightedPartIndex;
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
        materials[highlightedPartIndex].color = defaultColor;
    }

    public void Select()
    {
        materials[highlightedPartIndex].color = highLightColor;
    }

}
