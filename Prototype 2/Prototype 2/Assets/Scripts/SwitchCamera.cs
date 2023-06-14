using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public GameObject frontCamera;
    public GameObject BackCamera;
    // Start is called before the first frame update
    void Start()
    {
        BackCamera.SetActive(true);
        frontCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("switch"))
        {
            if (BackCamera.activeSelf)
            {
                BackCamera.SetActive(false);
                frontCamera.SetActive(true);
            }
            else
            {
                BackCamera.SetActive(true);
                frontCamera.SetActive(false);
            }
        }
    }
}
