using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="plant data",menuName ="PlantData")]
public class PlantData : ScriptableObject
{
    public enum THRET { None,Low,Moderate,High}
    [SerializeField]
    private string Name;
    [SerializeField]
    private THRET Age;
    [SerializeField]
    private Texture Email;



}