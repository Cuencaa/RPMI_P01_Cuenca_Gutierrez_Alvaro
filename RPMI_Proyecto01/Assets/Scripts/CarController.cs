// Librerias usadas en el script.
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


public class CarController : MonoBehaviour
{ // Inicio de la clase CarController.

    public int score;

    public int score2;

    public float speed;

    public float sideSpeed;

    public int collectablesScore;

    public int specialScore;

    public int enemyScore;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI specialScoreText;

    public TextMeshProUGUI gameOverText;

    public TextMeshProUGUI winText;

    // Función que se ejecuta el primer frame que el script está activo.
    // La función "Start" solo se ejecuta UNA VEZ.
    void Start()
    { // Inicio de la función "Start".

        //print("Se ejecuta la función de Start");

        //Indica cual es la puntuación inicial.
        score = 0;

        //Indica cual es la puntuación especial inicial.
        score2 = 0;

        //Desactiva el componente de texto de scoreText.
        scoreText.enabled = false;

        //Desactiva el componente de texto de scoreText.
        //scoreText.gameObject.SetActive(false);

        //Desactiva el componente de texto de specialScoreText.
        specialScoreText.enabled = false;

        //Desactiva el componente de texto de specialScoreText.
        //specialScoreText.gameObject.SetActive(false);

        gameOverText.enabled = false;

        winText.enabled = false;

    } // Final de la función "Start".

    // Función que se ejecuta cada frame que el script está activo.
    void Update()
    { // Inicio de la función "Update".

        //print("Se ejecuta la función de Update");

        //Hace que el juego se cierre cuando se pulsa la tecla escape.
        if (Input.GetKey(KeyCode.Escape))
        {

            //Cierra la aplicación.
            Application.Quit();

        }

        //Hace que cuando se pulse la tecla "W" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
        if (Input.GetKey(KeyCode.W))
        {

            //Hace que "Car" se desplaze en la dirección Z 0.001f unidades cada frame.
            //transform.Translate(0, 0, speed * 0.001f);

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(0, 0, speed * 0.2f);

            //Hace que cuando se pulse la tecla "D" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
            if (Input.GetKey(KeyCode.D))
            {

                //Hace que "Car" se desplaze en la dirección X 0.001f unidades cada frame.
                transform.Translate(sideSpeed * Time.deltaTime, 0, 0);

            }

            //Hace que cuando se pulse la tecla "S" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
            if (Input.GetKey(KeyCode.A))
            {

                //Hace que "Car" se desplaze en la dirección -X 0.001f unidades cada frame.
                transform.Translate(-sideSpeed * Time.deltaTime, 0, 0);

            }

        }

        //Hace que cuando se pulse la tecla "S" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
        if (Input.GetKey(KeyCode.S))
        {

            //Hace que "Car" se desplaze en la dirección -Z 0.001f unidades cada frame.
            //transform.Translate(0, 0, -speed * 0.0005f);

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(0, 0, -speed * 0.1f);

            //Hace que cuando se pulse la tecla "D" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
            if (Input.GetKey(KeyCode.D))
            {

                //Hace que "Car" se desplaze en la dirección X 0.001f unidades cada frame.
                transform.Translate(sideSpeed * Time.deltaTime, 0, 0);

            }

            //Hace que cuando se pulse la tecla "S" el objeto "Car" se desplazará, dependiendo de la línea de código dentro del "if".
            if (Input.GetKey(KeyCode.A))
            {

                //Hace que "Car" se desplaze en la dirección -X 0.001f unidades cada frame.
                transform.Translate(-sideSpeed * Time.deltaTime, 0, 0);

            }

        }

        //Hace que cuando se pulse la tecla "Space" el objeto "Car" se desplazará al doble de la velocidad de "speed*0.001f".
        if (Input.GetKey(KeyCode.Space))
        {
            //Hace que "Car" se desplaze en la dirección Z "speed * 0.001f" unidades cada frame.
            //transform.Translate(0, 0, (speed * 0.001f) * 2);

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(0, 0, (speed * 0.2f) * 2);

        }

    }// Final de la función "Update".

    private void OnCollisionEnter(Collision collision)
    {

        //print("bump");
        
        //Comprueba si se choca son un objeto con el tag "Collectables".
        if (collision.gameObject.CompareTag("Collectables"))
        {
            //Indica cual es la puntuación que se añade a la variable.
            score = score + collectablesScore;

            //Indica cual es el texto que se mostrará.
            scoreText.text = score.ToString();

            //Activa la puntuación cuando esta sea mayor a 0.
            if (score > 0)
            {

                scoreText.enabled = true;

            }
            //Si la puntuación es igual o menor que 0 no se mostrara texto.
            else 
            {

                scoreText.enabled = false;

            }

            //Añade +20 a score en el marcador.
            print("Points +20 " + score);

            //Añade +20 a score en el marcador + posibilidad de añadir otras operaciones.
            //print($"Points +20 {score}");

        }
        
        //Comprueba si se choca son un objeto con el tag "Special".
        if (collision.gameObject.CompareTag("Special"))
        {
            //Indica cual es la puntuación que se añade a la variable "score2" o marcador especial.
            score2 = score2 + specialScore;

            //Indica cual es el texto que se mostrará en el marcador especial.
            specialScoreText.text = score2.ToString();

            //Activa la puntuación especial cuando esta sea mayor a 0.
            if (score > 0)
            {

                specialScoreText.enabled = true;

            }
            //Si la puntuación especial es igual o menor que 0 no se mostrara texto.
            else
            {

                specialScoreText.enabled = false;

            }

            //Añade +30 a score2 en el marcador especial.
            print("Points +30! " + score2);

            //Añade +30 a score en el marcador especial + posibilidad de añadir otras operaciones.
            //print($"Points +30! {score}");

        }

        //Comprueba si se choca son un objeto con el tag "Enemy".
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Indica cual es la puntuación que se substrae a la variable.
            score = score + enemyScore;

            //Indica cual es el texto que se mostrará.
            scoreText.text = score.ToString();

            //Quita 10 a score en el marcador.
            print("Points -10 " + score);

            //Quita 10 a score en el marcador + posibilidad de añadir otras operaciones.
            //print($"Points -30 {score}");

        }

        if (collision.gameObject.CompareTag("GameOver"))
        {       
            
            //Quita todos los puntos al perder
            score = score - score;

            scoreText.enabled = false;

            //Quita todos los puntos especiales al perder.
            score2 = score2 - score2;

            specialScoreText.enabled = false;

            //Muestra el texto gameOverText al chocar con un objeto con el tag "GameOver".
            if (collision.gameObject.CompareTag("GameOver"))
            {

                gameOverText.enabled = true;

            }
            
            else
            {

                gameOverText.enabled = false;

            }

            //Destruye el script.
            Destroy(this);

            //Acaba la partida.
            print("Game Over");

        }

        if (collision.gameObject.CompareTag("Win"))
        {
           
            //Muestra el marcador final.
            print("You won! Points: " + score);

            print("You won! Special points: " + score2);

            //Muestra el texto winText al chocar con un objeto con el tag "WIN".
            if (collision.gameObject.CompareTag("Win"))
            {

                winText.enabled = true;

            }

            else
            {

                winText.enabled = false;

            }

        }

    }

}// Final de la clase CarController.
