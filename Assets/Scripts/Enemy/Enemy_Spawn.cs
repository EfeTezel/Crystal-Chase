using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject Enemy_prefab;
    public Button try_button;

    void Start()
    {
        
        for (int i = 0; i < 10; i++)
        {
            float random_x = Random.Range(-12, 12);
            float random_y = Random.Range(-11, 11);
            while (random_x > -2 && random_x < 2)
            {
                random_x = Random.Range(-12, 12);
            }
            while (random_y > -2 && random_y < 2)
            {
                random_y = Random.Range(-12, 12);
            }
            Vector2 spawnPosition = new Vector2(random_x, random_y);
            Instantiate(Enemy_prefab, new Vector3(spawnPosition.x, spawnPosition.y, 0.1f), Quaternion.identity);
        }
    }
    public void button_visibilty()
    {
        try_button.gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
