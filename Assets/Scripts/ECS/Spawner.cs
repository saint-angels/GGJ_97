using Unity.Entities;
using Unity.Mathematics;

// ReSharper disable once InconsistentNaming
public struct Spawner : IComponentData
{
    public float3 Origin;
    public int CountX;
    public int CountY;
    public Entity Prefab;
}
