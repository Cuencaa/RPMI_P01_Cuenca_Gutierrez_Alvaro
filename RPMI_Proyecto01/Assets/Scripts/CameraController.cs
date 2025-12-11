using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{

    public Transform car1;

    public Transform car2;

    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car1.position + offset;

        transform.position = car2.position + offset;

    }
}
