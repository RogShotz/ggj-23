using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABehavior : MonoBehaviour
{
    public ProjectileBehavior projectile;
    public Vector3 launchOffset;
    private float delay = 1f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 3f);
        launchOffset = new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void Shoot()
    {
        for (int i = 0; i < 3; i++)
        {
            if (timer > delay)
            {
                timer = 0;
                Instantiate(projectile, launchOffset, transform.rotation);
            }
            
        }

    }

}
