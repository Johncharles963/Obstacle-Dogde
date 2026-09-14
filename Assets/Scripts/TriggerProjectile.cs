using UnityEngine;
using System.Collections;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    float yPosition = 10f;
    float xSpawnRange;
    float zSpawnRange;
    float spawnRange = 10f;
    float intervalMin = 0f;
    float intervalMax = 5f;
    bool onCooldown = false;
    float cooldownTimer = 0f;
    float cooldownDuration = 3f;
    [SerializeField]  float projectTotal = 5;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!onCooldown)
            {
                onCooldown = true;
                for (int i = 0; i < projectTotal; i++)
                {
                    StartCoroutine(SpawnProjectile(UnityEngine.Random.Range(intervalMin, intervalMax)));
                }

            }
            
        }
    }

    private void Update()
    {
        if (onCooldown)
        {
            cooldownTimer += Time.deltaTime;
        }
        if(cooldownTimer >= cooldownDuration)
        {
            onCooldown = false;
            cooldownTimer = 0f;
        }
    }

    IEnumerator SpawnProjectile(float delay)
    {
        yield return new WaitForSeconds(delay);
        xSpawnRange = UnityEngine.Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange);
        zSpawnRange = UnityEngine.Random.Range(transform.position.z - spawnRange, transform.position.z + spawnRange);
        Instantiate(projectile, new Vector3(xSpawnRange, yPosition, zSpawnRange), transform.rotation);
    }

}
