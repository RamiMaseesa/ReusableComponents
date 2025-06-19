using MyGame.Interfaces;
using UnityEngine;

public class SpawnPickUps : MonoBehaviour
{
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private GameObject shieldPrefab;

    private float matchDuration = 180f;
    private float timeElapsed = 0f;

    private float nextSpawnTime = 0f;

    void Update() {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= matchDuration)
            return;

        float spawnInterval;

        spawnInterval = Mathf.Lerp(8f, 6f, timeElapsed / 120f);

        if (Time.time >= nextSpawnTime) {
            SpawnRandomPickUp();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnRandomPickUp() {
        float roll = Random.value;

        GameObject obj;

        if (roll < 0.90f)
            obj = Instantiate(heartPrefab, transform.position, Quaternion.identity);
        else
            obj = Instantiate(shieldPrefab, transform.position, Quaternion.identity);

        obj.transform.position = obj.GetComponent<ISpawn>().SpawnObj();
    }
}
