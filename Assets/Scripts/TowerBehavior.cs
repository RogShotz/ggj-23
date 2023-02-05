using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public ProjectileBehavior projectile;
    public Vector3 launchOffset;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1f);
        launchOffset = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(projectile, launchOffset, transform.rotation);
    }
}
