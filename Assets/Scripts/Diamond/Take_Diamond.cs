using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Take_Diamond : MonoBehaviour
{
    Component comp;
    public float taken_diamond;
    public GameObject diamond_prefab;
    public TextMeshProUGUI diamond_text;
    public TextMeshProUGUI win_text;
    public Button try_button;
    void Start()
    {
        comp = GetComponent<Player_Move>();
        win_text.enabled = false;
        try_button.gameObject.SetActive(false);
        for (int i = 0; i < 10; i++)
        {
            Vector2 spawnPosition= new Vector2 (Random.Range(-12, 12), Random.Range(-11, 11));
            Instantiate(diamond_prefab, new Vector3(spawnPosition.x, spawnPosition.y, 0.1f), Quaternion.identity);
        }
        taken_diamond = 0;
    }

  
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
            taken_diamond++;
            diamond_text.text = taken_diamond.ToString();
            if (taken_diamond == 10)
            {
                win_text.enabled = true;
                try_button.gameObject.SetActive(true);
                GetComponent<Player_Move>().enabled = false;
                Time.timeScale = 0f;
            }
        }
    }
}
