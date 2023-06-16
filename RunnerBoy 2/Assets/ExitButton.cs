using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{

    public Button exitButton;

    void Start()
    {
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

   public void TaskOnClick()
    {
        Application.Quit();
        Debug.Log("You touched this button.");
    }
}