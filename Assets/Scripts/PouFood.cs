using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouFood : MonoBehaviour
{
    // Tämä metodi kutsutaan, kun jokin objekti osuu tämän objektin Collider-alueeseen
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        // Tarkistetaan, onko törmänneellä objektilla tagina "food"
        if (other.gameObject.CompareTag("food"))
        {
            // Poistetaan "food"-objekti
            Destroy(other.gameObject);

            Debug.Log("Koskee");
        }
    }
}
