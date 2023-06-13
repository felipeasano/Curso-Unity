using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4.5f, -6f);
    private Vector3 offsetRotate;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.rotation = player.transform.rotation;
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Vector3 novaposicao = new Vector3(-0.09f, 2.3f, 1f);
            offset = novaposicao;
            transform.position = player.transform.position + offset;
        }
        else
        {
            offset = new Vector3(0, 4.5f, -6f);
            transform.position = player.transform.position + offset;
        }
    }
}
