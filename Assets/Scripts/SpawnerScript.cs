using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    [SerializeField]
    private GameObject[] treePrefabs;
    [SerializeField]
    private GameObject[] cloudPrefabs;
    private float pipeSpawnPeriod = 4.0f;
    private float pipetimeout;
    private float envSpawnPeriod = 3.5f;
    private float envtimeout;

    void Start()
    {
        pipetimeout = pipeSpawnPeriod;
        envtimeout = envSpawnPeriod;
    }

    void Update()
    {
        pipetimeout -= Time.deltaTime;
        if (pipetimeout <= 0.0f)
        {
            SpawnPipe();
            pipetimeout = pipeSpawnPeriod;
        }

        envtimeout -= Time.deltaTime;
        if (envtimeout <= 0.0f)
        {
            SpawnTree();
            SpawnCloud();
            envtimeout = envSpawnPeriod;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate(pipePrefab);
        pipe.transform.position = this.transform.position + Random.Range(-2f, 2f) * Vector3.up;
    }

    private void SpawnTree()
    {
        GameObject envObject = GameObject.Instantiate(treePrefabs[Random.Range(0, treePrefabs.Length)]);
        float scale = Random.Range(3f, 5f);
        envObject.transform.localScale = new Vector3(scale, scale, scale);
        envObject.transform.position = new Vector3(11f, scale * 0.6f - 5f, 0);

    }

    private void SpawnCloud()
    {
        GameObject envObject = GameObject.Instantiate(cloudPrefabs[Random.Range(0, cloudPrefabs.Length)]);
        float scale = Random.Range(1f, 2f);
        envObject.transform.localScale = new Vector3(scale, scale, scale);
        envObject.transform.position = this.transform.position + Random.Range(2f, 4f) * Vector3.up;
    }

}
