using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        // Get the button component of the current object.
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Action that is performed when the button is clicked
    void OnClick()
    {
        SceneManager.LoadScene("JeffScene");
    }
}