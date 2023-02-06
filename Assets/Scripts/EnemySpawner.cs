using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyBehavior small;
    public EnemyBehavior big;
    public EnemyBehavior fly;
    public float timer = 0f;
    public float delay = 3f;
    public Vector3 launchOffset;
    public int randomGem = Random.Range(0, 3);
    // Start is called before the first frame update
    void Start()
    {
        launchOffset = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            if (randomGem == 0)
            {
                Instantiate(small, launchOffset, transform.rotation);
            }
            else if (randomGem == 1)
            {
                Instantiate(big, launchOffset, transform.rotation);
            }
            else
            {
                Instantiate(fly, launchOffset, transform.rotation);
            }
            randomGem = Random.Range(0, 3);
            timer = 0f;
            delay = Random.Range(1, 10);
            launchOffset = new Vector3(transform.position.x + Random.Range(0, 2), transform.position.y, transform.position.z);
        }
    }
}
