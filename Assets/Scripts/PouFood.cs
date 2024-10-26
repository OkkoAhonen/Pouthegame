using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouFood : MonoBehaviour
{
     [SerializeField] gameManager gamemanager;


    // Tämä metodi kutsutaan, kun jokin objekti osuu tämän objektin Collider-alueeseen
    private void Start() //En ole varma miksi tämä on???
    {
        

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        // Tarkistetaan, onko törmänneellä objektilla tagina "food"
        if (other.gameObject.CompareTag("food"))
        {
            
            // Poistetaan "food"-objekti
            Destroy(other.gameObject);

            Debug.Log("Koskee");
            gamemanager.progress += 50;
        }
    }
}
