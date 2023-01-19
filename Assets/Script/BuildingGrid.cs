using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
public class BuildingGrid : MonoBehaviour
{
    private Building[,] grid;
    private Building flyingBuilding;
    private Camera mainCamera;
    public Vector2Int GridSize = new Vector2Int(10, 10);
    private void Awake()
    {
        grid = new Building[GridSize.x, GridSize.y];

        mainCamera = Camera.main;
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        if (flyingBuilding != null)
        {
            Destroy(flyingBuilding.gameObject);
        }

        flyingBuilding = Instantiate(buildingPrefab);
    }

    private void Update()
    {
        if (flyingBuilding != null)
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (groundPlane.Raycast(ray, out float position))
            {
            Vector3 worldPosition = ray.GetPoint(position);

            flyingBuilding.transform.position = worldPosition;
            }
        }
    }
    


}