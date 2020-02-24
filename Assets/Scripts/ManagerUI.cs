using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& UI.activeSelf == false)
        {
            UI.SetActive(true);
        }
        else if (UI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            UI.SetActive(false);
        }
    }


}
