using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject prefab;
    public Text moneyText;
    public int money;

    private void Update()
    {
        moneyText.text = "Money: " + money;
    }

    public void SpawnPrefab()
    {
        Vector2 position = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Instantiate(prefab, position, Quaternion.identity);
    }
}
