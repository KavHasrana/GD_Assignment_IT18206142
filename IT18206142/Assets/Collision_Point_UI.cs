using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision_Point_UI : MonoBehaviour
{
    public Text scoreTXT, healthTXT;
    public int score, health;

    public loadGameAgain loadGame;
    public GameObject blastPrefab;

    private void Start()
    {
        score = 0;
        health = 3;
    }

    private void Update()
    {
        if (health <= 0)
        {
            //Game Restart and Destroy Player
            loadGame.enabled = true;
            GameObject bEffect = Instantiate(blastPrefab, transform.position, Quaternion.identity);
            Destroy(bEffect, 1f);
            Destroy(gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            health -= 1;
            healthTXT.text = health.ToString();
        }

        if (collision.collider.tag == "coin")
        {
            score += 5;
            scoreTXT.text = score.ToString();
        }
    }
}

    
