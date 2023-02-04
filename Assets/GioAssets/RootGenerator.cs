using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RootGenerator : MonoBehaviour
{

    public GameObject obj;
    float y = 5f;
    float yAcc = -0.1f;
    float x = 0f;
    float xAcc = 0f;
    private int tick = 0;
    float xSpd = 0.01f;

    bool generateRoot = true;


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


        if (generateRoot)
        {
            if (tick % 5 == 0)
            {

                // left
                if (Input.GetKey(KeyCode.A))
                {
                    xAcc -= xSpd;
                }

                // right
                if (Input.GetKey(KeyCode.D))
                {
                    xAcc += xSpd;
                }

                x += xAcc;

                y += yAcc;
                GameObject newObj = Instantiate(obj, new Vector3(x, y, 0), transform.rotation);

                float rot = Mathf.Atan2(yAcc, xAcc) * 180 / Mathf.PI;
                /*Debug.Log(rot);*/

                newObj.transform.Rotate(new Vector3(0, 0, 90 + rot));

            }
        }


    }
}
