using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if ((Input.GetAxisRaw("Vertical")> 0) && (transform.position.y<=6))
        {
            transform.Translate(0, 0.1f, 0);
        }
            else if ((Input.GetAxisRaw("Vertical")< 0) && (transform.position.y>=0))
        {
            transform.Translate(-0, -0.1f, 0);
        }
    }
}
