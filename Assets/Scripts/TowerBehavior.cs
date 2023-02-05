using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public ProjectileBehavior projectile;
    public Vector3 launchOffset;
    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1f);
        launchOffset = new Vector3(transform.position.x + 0.5f, transform.position.y + 0.4f, transform.position.z); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(projectile, launchOffset, transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy") == true)
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                health--;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                health--;
            }
        }
    }

}
