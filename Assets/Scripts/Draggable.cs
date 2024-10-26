using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        // Lasketaan ero objektin sijainnin ja hiiren sijainnin v‰lill‰ pelimaailmassa
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }

    void OnMouseDrag()
    {
        // P‰ivitet‰‰n objektin sijainti hiiren sijainnin perusteella
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
    }
}
// koodi teknisesti loppyy t‰h‰n
