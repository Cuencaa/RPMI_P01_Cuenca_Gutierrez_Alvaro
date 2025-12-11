using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Special : MonoBehaviour
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

        //print("bump");

        if (collision.gameObject.CompareTag("Player"))
        {
            //Destruye el objeto al que este añadido este script.
            Destroy(gameObject);

        }

    }


}

