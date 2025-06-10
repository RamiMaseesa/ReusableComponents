using UnityEngine;

public class SpawnTraps : MonoBehaviour {

    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private GameObject sawPrefab;

    private float matchDuration = 180f;
    private float timeElapsed = 0f;

    private float nextSpawnTime = 0f;

    void Update() {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= matchDuration)
            return;

        float spawnInterval;

        spawnInterval = Mathf.Lerp(.9f, .4f, timeElapsed / 120f);

        if (Time.time >= nextSpawnTime) {
            SpawnRandomTrap();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnRandomTrap() {
        float roll = Random.value;

        GameObject obj;

        if (roll < 0.95f)
            obj = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        else
            obj = Instantiate(sawPrefab, transform.position, Quaternion.identity);

        obj.transform.position = obj.GetComponent<ISpawn>().SpawnTrap();
    }
}
