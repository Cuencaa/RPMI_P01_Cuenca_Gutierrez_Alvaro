using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        //print("hit");

        if (collision.gameObject.CompareTag("Player"))
        {
            //Destruye el objeto al que este añadido este script.
            Destroy(gameObject);

        }
    }

}

