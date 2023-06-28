using System.Collections;
using System.Collections.Generic;
using nyy.FSMBuilder;
using nyy.System_Component;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "x",menuName = "B")]
public class A : ScriptableObject
{
    public float x = 0;
    
    public void Add()
    {
        x += 3;
    }
}
