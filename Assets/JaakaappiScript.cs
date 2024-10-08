using UnityEngine;
using UnityEngine.UI; // Tarvitaan UI-elementtien k‰yttˆˆn (nappien ja tekstin k‰sittely)

public class MoveObjectOnClick : MonoBehaviour
{
    public Button moveButton; // Nappi UI:ssa
    public GameObject objectToMove; // Objekti, jota liikutetaan
    public float speed = 4.0f; // Liikkumisnopeus

    private Vector3 targetPosition; // M‰‰r‰np‰‰
    private bool shouldMove = false; // Tieto siit‰, pit‰isikˆ objektin liikkua

    void Start()
    {
        // Alkuper‰inen sijainti
        targetPosition = objectToMove.transform.position;

        // Lis‰t‰‰n kuuntelija nappiin
        moveButton.onClick.AddListener(OnMoveButtonClicked);
    }

    void Update()
    {
        // Jos objektin pit‰isi liikkua, liikuta sit‰ kohti m‰‰r‰np‰‰t‰
        if (shouldMove)
        {
            // Liikutetaan objektia kohti m‰‰r‰np‰‰t‰ tietyll‰ nopeudella
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition, speed * Time.deltaTime);

            // Tarkistetaan, onko objekti saavuttanut m‰‰r‰np‰‰n
            if (objectToMove.transform.position == targetPosition)
            {
                shouldMove = false; // Pys‰ytet‰‰n liike, kun m‰‰r‰np‰‰ saavutetaan
            }
        }
    }

    void OnMoveButtonClicked()
    {
        // Asetetaan uusi m‰‰r‰np‰‰ 500 yksikkˆ‰ oikealle x-akselilla
        targetPosition = new Vector3(objectToMove.transform.position.x + 5, objectToMove.transform.position.y, objectToMove.transform.position.z);
        shouldMove = true; // K‰ynnistet‰‰n liike
    }
}