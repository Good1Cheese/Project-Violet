using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemSelectable : ISelectable
{
    [SerializeField] Color highLightColor;
    new Renderer renderer;
    Material[] materials;
    List<Color> startColors = new List<Color>();

    void Start()
    {
        renderer = GetComponent<Renderer>();
        materials = renderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            startColors.Add(materials[i].color);
        }
    }

    public override void Deselect()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = startColors[i];
        }
    }

    public override void Select()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = highLightColor;
        }
    }

}
