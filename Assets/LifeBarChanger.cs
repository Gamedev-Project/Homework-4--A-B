using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class LifeBarChanger : MonoBehaviour
{
    private TextMeshPro textField;
    private int number;
    void Start()    {
        textField = GetComponent<TextMeshPro>();
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        this.textField.text = newNumber.ToString();
    }
}
