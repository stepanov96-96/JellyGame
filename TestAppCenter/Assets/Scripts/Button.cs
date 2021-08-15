using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Icon;
    public GameObject Icon1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void UpButton()
    {
        Icon.SetActive(!Icon.activeSelf);

        if (Icon.activeSelf)
        {
            Icon1.SetActive(false);
        }
        else
        {
            Icon1.SetActive(true);
        }
    }
}
