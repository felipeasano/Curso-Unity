using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // o tipo GameObject representa objetos dentro do cenario podendo apontar ou receber a referencia de um deles
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 5, -8);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
