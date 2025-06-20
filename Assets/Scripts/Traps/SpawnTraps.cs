using UnityEngine;
using MyGame.Interfaces;
public class SpawnTraps : MonoBehaviour {

    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private GameObject sawPrefab;
    [SerializeField] private GameObject spikePrefab;
    [SerializeField] private GameObject firePrefab;
    [SerializeField] private GameObject shadpwPrefab;

    private float matchDuration = 180f;
    private float timeElapsed = 0f;

    private float nextSpawnTime = 0f;

    void Update() {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= matchDuration)
            return;

        float spawnInterval;

        spawnInterval = Mathf.Lerp(.9f, .4f, timeElapsed / 120f);
        //spawnInterval = Mathf.Lerp(.1f, .1f, timeElapsed / 120f);

        if (Time.time >= nextSpawnTime) {
            SpawnRandomTrap();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnRandomTrap() {
        float roll = Random.Range(0f, 100f);
        GameObject obj;

        if (roll < 60f)
            obj = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        else if (roll < 80f)
            obj = Instantiate(sawPrefab, transform.position, Quaternion.identity);
        else if (roll < 90f)
            obj = Instantiate(spikePrefab, transform.position, Quaternion.identity);
        else if (roll < 95f)
            obj = Instantiate(shadpwPrefab, transform.position, Quaternion.identity);
        else
            obj = Instantiate(firePrefab, transform.position, Quaternion.identity);

        obj.transform.position = obj.GetComponent<ISpawn>().SpawnObj();
    }
}
