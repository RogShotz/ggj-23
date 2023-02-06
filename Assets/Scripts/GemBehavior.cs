using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    public int point = 1;
    public float speed = 4.5f;
    private TreeBehavior tree;
    // Start is called before the first frame update

    void Awake()
    {
        tree = GameObject.Find("TreeSprite").GetComponent<TreeBehavior>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1)
        {
            transform.position += -transform.up * speed * Time.deltaTime;
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Root"))
        {
            Destroy(gameObject);
            tree.setPoints(point);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        tree.setPoints(point);
    }

}
