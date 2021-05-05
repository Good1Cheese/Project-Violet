using UnityEngine;

public abstract class ISelectable : MonoBehaviour
{
    public abstract void Select();
    public abstract void Deselect();
}