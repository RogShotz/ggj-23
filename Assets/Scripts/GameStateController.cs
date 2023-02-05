using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public enum State
    {
        Rooting,
        Defense
    }

    State gameState;

    public Camera mainCamera;

    public GameObject rootObj;

    RootGenerator rootGenerator;

    const float timeRoot = 5;
    float timeRemaining = timeRoot;
    const float camZ = -10f;

    Vector2 camDefensePos = new Vector2(0, 0);

    Vector2 camTarget;


    // Start is called before the first frame update
    void Awake()
    {

        rootGenerator = rootObj.GetComponent<RootGenerator>();
        mainCamera.transform.position = new Vector3(0, 0, camZ);

    }

    // Update is called once per frame
    void Update()
    {


        switch (gameState) {
            case State.Defense:
                camTarget = camDefensePos;

                break;

            case State.Rooting:
                camTarget = rootGenerator.GetPosition(); ;

                if (timeRemaining > 0) {

                    timeRemaining -= Time.deltaTime;


                } else {
                    timeRemaining = timeRoot;
                    SwitchStates();

                }

                break;
        }



        mainCamera.transform.position = Vector2.Lerp(mainCamera.transform.position, Vector2to3(camTarget), 0.05f);
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, camZ);

    }


    void SwitchStates() {
        Debug.Log("Switch states");
        if (gameState == State.Defense) {

            gameState = State.Rooting;

            camTarget = rootGenerator.GetPosition();

        } else {
            gameState = State.Defense;

            camTarget = camDefensePos;

        }
    }

    private Vector3 Vector2to3(Vector2 v) {
        return new Vector3(v.x, v.y, camZ);
    }

    public State GetState() {
        return gameState;
    }
}
