using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Building buildingToPlace;
    public CustomCursor cursor;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && buildingToPlace != null)
        {
            Instantiate(buildingToPlace, cursor.transform.position, Quaternion.identity);
            buildingToPlace = null;
            cursor.gameObject.SetActive(false);
            Cursor.visible = true;
        }
    }

    public void ConstructionBuilding(Building building)
    {
        cursor.gameObject.SetActive(true);
        cursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
        buildingToPlace = building;
        Cursor.visible = false;
    }
}