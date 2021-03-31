using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovemnt : PeiceMovement
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpARoow();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightARoow();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftARoow();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownARoow();
        }

    }
}
