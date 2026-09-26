using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Move : MonoBehaviour
{
    public float difficultiy;
    Vector2 enemy_vector;
    Vector2 target;
    public Transform player_transform;
    public TextMeshProUGUI lose_text;
    Enemy_Spawn enemy_spawn;
    void Start()
    {
        enemy_spawn = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<Enemy_Spawn>();
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        lose_text = GameObject.FindGameObjectWithTag("text").GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        target = new Vector2(player_transform.position.x, player_transform.position.y);
        enemy_vector = new Vector2(transform.position.x,transform.position.y);
        if(enemy_vector.x > target.x)
        {
            enemy_vector.x -= 0.003f * difficultiy;
        }
        if (enemy_vector.x < target.x)
        {
            enemy_vector.x += 0.003f * difficultiy;
        }
        if (enemy_vector.y > target.y)
        {
            enemy_vector.y -= 0.003f * difficultiy;
        }
        if(enemy_vector.y < target.y)
        {
            enemy_vector.y += 0.003f * difficultiy;
        }
        transform.position = enemy_vector;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            lose_text.text = "You Lose";
            enemy_spawn.button_visibilty();
            lose_text.enabled = true;
            other.GetComponent<Player_Move>().enabled = false;
            Time.timeScale = 0f;
        }
    }
}
