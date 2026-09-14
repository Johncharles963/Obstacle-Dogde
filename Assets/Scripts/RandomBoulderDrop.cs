using UnityEngine;

public class RandomBoulderDrop : MonoBehaviour
{
    Transform transformForm;
    [SerializeField]GameObject boulder;
    float xSpawnRange;
    float ySpawnRange = 7f;
    float zSpawnRange;
    float spawnRange = 2f;
    float timer = 0;
    float interval = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            timer = 0;
            DropOnPlayer();
            interval = Random.Range(2, 3);
        }
    }

    void DropOnPlayer()
    {
        xSpawnRange = UnityEngine.Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange);
        zSpawnRange = UnityEngine.Random.Range(transform.position.z - spawnRange, transform.position.z + spawnRange);
        Instantiate(boulder, new Vector3(xSpawnRange, ySpawnRange, zSpawnRange), transform.rotation);
    }
}
