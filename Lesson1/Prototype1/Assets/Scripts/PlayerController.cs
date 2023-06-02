using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //o caracter "f" entra no final do numero para indicar seu tipo, no caso, um "float"
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
