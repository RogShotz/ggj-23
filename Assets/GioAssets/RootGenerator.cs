using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RootGenerator : MonoBehaviour
{

    public GameObject obj;
    float y = 5f;
    float x = 0f;
    float xAcc = 0f;
    private int tick = 0;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    private void Start()
    {


    }


    // Update is called once per frame
    void FixedUpdate()
    {
        tick++;
        


        if (tick % 5 == 0)
        {

            // left
            if (Input.GetKey(KeyCode.A))
            {
                xAcc -= 0.05f;
            }

            // right
            if (Input.GetKey(KeyCode.D))
            {
                xAcc += 0.05f;
            }

            x += xAcc;

            y -= 0.1f;
            GameObject newObj = Instantiate(obj, new Vector3(x, y, 0), transform.rotation);
            newObj.transform.Rotate(new Vector3(0, 0, xAcc * 360));

        }


    }
}
