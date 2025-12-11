using UnityEngine;

public class Collectionables : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }
     
    //Función que se ejecuta cada frame
    private void Update() 
    {
    
    }

    //Función que se ejecuta cuando un objeto choca con otro
    private void OnCollisionEnter(Collision collision)
    {
    
        //print("hit");

        if (collision.gameObject.CompareTag("Player")) 
        {
            //Destruye el objeto al que este añadido este script.
            Destroy(gameObject);

        }
        
        /*
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);

        }
        */

    }
   
}
