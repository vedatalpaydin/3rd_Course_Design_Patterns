using Unity.Entities;

public class Spawner : IComponentData
{
   public Entity Prefab;
   public int Erows;
   public int Ecols;
}
