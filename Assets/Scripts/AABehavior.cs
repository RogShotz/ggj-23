using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AABehavior : MonoBehaviour
{
    public ProjectileBehavior projectile;
    public Vector3 launchOffset;
    private float delay = 5f;
    private int burstShots = 3;
    private float timer = 0f;
    bool shoot = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 0.3f);
        launchOffset = new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay && burstShots == 3)
        {
            shoot = true;
            timer = 0f;
        }
        else if (burstShots < 1)
        {
            burstShots = 3;
            shoot = false;
        }
    }

    void Shoot()
    {
        if (shoot)
        {       
            Instantiate(projectile, launchOffset, transform.rotation);
            burstShots--;
        }

    }

}
