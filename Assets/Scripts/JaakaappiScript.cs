using UnityEngine;
using UnityEngine.UI; // Tarvitaan UI-elementtien k‰yttˆˆn (nappien ja tekstin k‰sittely)

public class MoveObjectOnClick : MonoBehaviour
{
    public Button moveButton; // Nappi UI:ssa
    public GameObject objectToMove; // Objekti, jota liikutetaan
    public float speed = 4.0f; // Liikkumisnopeus

    private Vector3 originalPosition; // Alkuper‰inen sijainti
    private Vector3 movedPosition; // Uusi sijainti (500 yksikkˆ‰ oikealle)
    private Vector3 targetPosition; // M‰‰r‰np‰‰
    private bool shouldMove = false; // Tieto siit‰, pit‰isikˆ objektin liikkua
    private bool isAtOriginalPosition = true; // Tieto siit‰, onko objekti alkuper‰isess‰ sijainnissa

    void Start()
    {
        // Tallennetaan alkuper‰inen sijainti
        originalPosition = objectToMove.transform.position;

        // Lasketaan siirtymisen j‰lkeinen sijainti (500 yksikkˆ‰ oikealle)
        movedPosition = new Vector3(originalPosition.x + 5, originalPosition.y, originalPosition.z);

        // Aluksi m‰‰r‰np‰‰ on alkuper‰inen sijainti
        targetPosition = originalPosition;

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
        // Vaihdetaan m‰‰r‰np‰‰t‰ riippuen siit‰, onko objekti alkuper‰isess‰ sijainnissa
        if (isAtOriginalPosition)
        {
            targetPosition = movedPosition; // Liikutaan 500 yksikkˆ‰ oikealle
        }
        else
        {
            targetPosition = originalPosition; // Liikutaan takaisin alkuper‰iseen sijaintiin
        }

        // K‰ynnistet‰‰n liike ja k‰‰nnet‰‰n tila
        shouldMove = true;
        isAtOriginalPosition = !isAtOriginalPosition; // Vaihdetaan tila
    }
}
