using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeBarShooter : KeyboardSpawner
{
    [SerializeField] LifeBarChanger scoreField;

    protected override GameObject spawnObject() {
        GameObject newObject = base.spawnObject();  // base = super

        // Modify the text field of the new object.
        LifeBarDecrease newObjectScoreAdder = newObject.GetComponent<LifeBarDecrease>();
        if (newObjectScoreAdder)
            newObjectScoreAdder.SetScoreField(scoreField);

        return newObject;
    }
}