using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 4.5f;
    public TowerBehavior tower;
    public AABehavior antiair;
    bool aa = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1 || aa)
        {
            transform.position += -transform.up * speed * Time.deltaTime;
            aa = true;
        }
        else if (tower != null)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (transform.position.x > 11)
        {
            Destroy(gameObject);
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.tag.Equals("Tower") == true)
        {
            Destroy(gameObject);
        }
             
    }

}
