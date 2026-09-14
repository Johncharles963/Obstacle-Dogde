using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    float speed;
    Vector3 playerPosition;

    void Start()
    {
        speed = UnityEngine.Random.Range(8f, 12f);
        playerPosition = GameObject.FindWithTag("Player").transform.position;
        Debug.Log("Start");
    }
    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        transform.LookAt(playerPosition);
    }
}
