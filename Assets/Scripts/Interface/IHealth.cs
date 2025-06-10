using UnityEngine;

public interface IHealth
{
    int Health { get; }

    public void RemoveHealthPoints(int healthToRemove);

    public void GenerateHearts();
}
