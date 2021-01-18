using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
      
        if (Input.GetKey(KeyCode.Space))
        {

            transform.Translate(Vector3.left * 3 * Time.deltaTime);
        }
    }
}
