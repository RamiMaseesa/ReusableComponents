using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private int health;
    [SerializeField] GameObject heart;
    private List<GameObject> hearts = new List<GameObject>();

    public int Health
    {
        get { return health; }
    }

    public void RemoveHealthPoints(int healthToRemove) {
        health -= healthToRemove;

        Destroy(hearts[hearts.Count - 1]);
        hearts.RemoveAt(hearts.Count - 1);

        if (hearts.Count == 0) GameEnd.Instance.TriggerLoss();
    }

    public bool CheckIfPlayerDead() {
        return health <= 0;
    }

    public void GenerateHearts() {
        for (int i = 0; i < health; i++) {
            GameObject tempHeart = Instantiate(heart, new Vector3(-8.5f + (i % 5), 4.5f - (i / 5), -9), Quaternion.identity);

            hearts.Add(tempHeart);
        }
    }
}
