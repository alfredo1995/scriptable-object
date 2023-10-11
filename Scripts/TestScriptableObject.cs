using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptableObject : MonoBehaviour
{
    [SerializeField] private TextScriptableObject textScriptableObject;

    private void Start()
    {
        Debug.Log(textScriptableObject.textString);
    }
}