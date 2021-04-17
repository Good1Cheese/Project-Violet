using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextWriter : MonoBehaviour
{
    InputField inputField;

    void Start()
    {
        inputField = GetComponent<InputField>();
        MainLinks.Instance.TextWriter = this;
    }

    public void Write(string text)
    {
        OpenField();
        if (inputField.text != text)
        {
            inputField.text = string.Format(text);
        }
    }

    public void HideField()
    {
        gameObject.SetActive(false);
    }

    void OpenField()
    {
        gameObject.SetActive(true);
    }
}
