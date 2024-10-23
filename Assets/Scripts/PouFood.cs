using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouFood : MonoBehaviour
{
     [SerializeField] gameManager gamemanager;


    // T�m� metodi kutsutaan, kun jokin objekti osuu t�m�n objektin Collider-alueeseen
    private void Start()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        // Tarkistetaan, onko t�rm�nneell� objektilla tagina "food"
        if (other.gameObject.CompareTag("food"))
        {
            
            // Poistetaan "food"-objekti
            Destroy(other.gameObject);

            Debug.Log("Koskee");
            gamemanager.progress += 50;
        }
    }
}
