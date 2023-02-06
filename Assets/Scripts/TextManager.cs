using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    private TreeBehavior tree;
    public TextMeshProUGUI livesRemaining;
    public TextMeshProUGUI points;

    void Awake()
    {
        tree = GameObject.Find("TreeSprite").GetComponent<TreeBehavior>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesRemaining.text = "Lives: " + tree.getLives().ToString();
        points.text = "Points: " + tree.getPoints().ToString();
    }
}
