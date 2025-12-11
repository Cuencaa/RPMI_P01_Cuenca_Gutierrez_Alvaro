using UnityEngine;

public class Vehicles : MonoBehaviour
{
    public GameObject car1;

    public GameObject car2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        car2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {

            car1.SetActive(true);
            car2.SetActive(false);

        }

        if (Input.GetKey(KeyCode.Alpha2))
        {

            car1.SetActive(false);
            car2.SetActive(true);

        }
    }
}
