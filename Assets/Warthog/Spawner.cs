using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Spawner : IComponentData
{
    public Entity Prefab;
    public int Erows, Ecolumns;
}
