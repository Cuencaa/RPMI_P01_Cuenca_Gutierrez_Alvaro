using UnityEngine;

public class WheelsController : MonoBehaviour
{
    //
    public Transform wheel;

    //Se refiere a la variable "rotationSpeed" y permite cambiarla desde el editor.
    public float rotationSpeed;

    //Variable que hace conocido "carRigidBody"
    public Rigidbody carRigidBody;

    //Activa la boolean "carMovement", para saber si el coche se mueve o no
    public bool positiveCarMovement = false;

    //Activa la boolean "carMovement", para saber si el coche se mueve o no
    public bool negativeCarMovement = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Indica que si la velocidad del coche es mayor a 0, "positiveCarMovement" = true.
        if (carRigidBody.linearVelocity.z > 0)
        {
           
            positiveCarMovement = true;

        }

        //Indica que si la velocidad del coche es igual a 0, "positiveCarMovement" = false.
        else
        {
            
            positiveCarMovement = false;

        }

        //Indica que si la velocidad del coche es menor a 0, "negativeCarMovement" = true.
        if (carRigidBody.linearVelocity.z < 0)
        {

            negativeCarMovement = true;

        }

        //Indica que si la velocidad del coche es igual a 0, "negativeCarMovement" = false.
        else
        {

            negativeCarMovement = false;

        }

        //Hace que si "positiveCarMovement" = true, las ruedas rotan hacia delante.
        if (positiveCarMovement) 
        {

            transform.Rotate(rotationSpeed, 0, 0);

        }

        //Hace que si "negativeCarMovement" = true, las ruedas rotan hacia atrás.
        if (negativeCarMovement)
        {

            transform.Rotate(-rotationSpeed, 0, 0);

        }

    }

}
