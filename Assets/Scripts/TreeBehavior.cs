using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehavior : MonoBehaviour
{
    public static int lives = 10;
    public static int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Tree hit");
            lives--;
        }
    }

    public int getLives()
    {
        return lives;
    }

    public void setLives(int val)
    {
        lives = val;
    }

    public int getPoints()
    {
        return points;
    }

    public void setPoints(int val)
    {
        points += val;
    }

}
