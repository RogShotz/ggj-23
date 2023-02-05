using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RootGenerator : MonoBehaviour
{

    public GameObject root;
    float y = -4f;
    float yAcc = -0.1f;
    float x = 0f;
    float xAcc = 0f;
    private int tick = 0;
    float xSpd = 0.01f;


    public GameStateController gameStateController;



    // Start is called before the first frame update
    void Awake()
    {
        gameStateController = gameStateController.GetComponent<GameStateController>();
        
    }

    private void Start()
    {


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        switch (gameStateController.GetState()) {
            case GameStateController.State.Rooting:
                tick++;
                GenerateRoot(tick);
               
                break;
        }
        


    }


    void GenerateRoot(int tick) {
        // Generate root
        if (tick % 5 == 0) {

            // left
            if (Input.GetKey(KeyCode.A)) {
                xAcc -= xSpd;
            }

            // right
            if (Input.GetKey(KeyCode.D)) {
                xAcc += xSpd;
            }

            x += xAcc;

            y += yAcc;
            GameObject newRoot = Instantiate(root, new Vector3(x, y, 0), transform.rotation);

            float rot = Mathf.Atan2(yAcc, xAcc) * 180 / Mathf.PI;

            newRoot.transform.Rotate(new Vector3(0, 0, 90 + rot));


        }
    }

    // Returns the location of the last 
    public Vector2 GetPosition() {
        return new Vector2(0, y);
    }
}
