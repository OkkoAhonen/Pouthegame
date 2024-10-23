using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouFood : MonoBehaviour
{
    gameManager manager;
    // Tämä metodi kutsutaan, kun jokin objekti osuu tämän objektin Collider-alueeseen
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        // Tarkistetaan, onko törmänneellä objektilla tagina "food"
        if (other.gameObject.CompareTag("food"))
        {
            manager.progress += 50;
            // Poistetaan "food"-objekti
            Destroy(other.gameObject);

            Debug.Log("Koskee");
        }
    }
}
