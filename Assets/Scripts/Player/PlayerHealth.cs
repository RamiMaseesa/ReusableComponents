using System.Collections.Generic;
using UnityEngine;
using MyGame.Interfaces;
using System.Collections;
public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private int health;
    [SerializeField] private GameObject heart;

    private List<GameObject> hearts = new List<GameObject>();
    private bool isInvincible = false; // <- Damage immunity flag

    public int Health => health;

    public void RemoveHealthPoints(int healthToRemove) {
        if (isInvincible) return; // Ignore damage if invincible

        health -= healthToRemove;

        if (hearts.Count > 0) {
            Destroy(hearts[hearts.Count - 1]);
            hearts.RemoveAt(hearts.Count - 1);
        }

        if (hearts.Count == 0 || health <= 0)
            GameEnd.Instance.TriggerLoss();
    }

    public bool CheckIfPlayerDead() {
        return health <= 0;
    }

    public void GenerateHearts() {
        for (int i = 0; i < health; i++) {
            GameObject tempHeart = Instantiate(
                heart,
                new Vector3(-8.5f + (i % 5), 4.5f - (i / 5), -9),
                Quaternion.identity
            );
            hearts.Add(tempHeart);
        }
    }

    public void AddHealthPoint() {
        health += 1;
        int i = hearts.Count;
        Vector3 newHeartPos = new Vector3(-8.5f + (i % 5), 4.5f - (i / 5), -9);
        GameObject tempHeart = Instantiate(heart, newHeartPos, Quaternion.identity);
        hearts.Add(tempHeart);
    }

    // 👇 Add this method to start 5s damage immunity
    public void ActivateTemporaryImmunity(float duration = 5f) {
        StartCoroutine(TemporaryImmunityCoroutine(duration));
    }

    private IEnumerator TemporaryImmunityCoroutine(float duration) {
        isInvincible = true;
        yield return new WaitForSeconds(duration);
        isInvincible = false;
    }
}
