using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public ProjectileBehavior projectile;
    public Transform LaunchOffset;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(projectile, LaunchOffset.position, transform.rotation);
    }
}
