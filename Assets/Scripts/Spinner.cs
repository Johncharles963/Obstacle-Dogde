using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;
    [SerializeField] float zValue = 0;
    [SerializeField] float speed = 3000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue * Time.deltaTime * speed, yValue * Time.deltaTime * speed, zValue * Time.deltaTime * speed);
    }
}
