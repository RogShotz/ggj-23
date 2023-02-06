using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GemBehavior gem;
    public float timer = 0f;
    public float delay = 3f;
    public Vector3 launchOffset;
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
            Instantiate(gem, launchOffset, transform.rotation);
            timer = 0f;
            delay = Random.Range(1, 10);
            launchOffset = new Vector3(transform.position.x + Random.Range(0,2), transform.position.y, transform.position.z);
        }
    }
}
