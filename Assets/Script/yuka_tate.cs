using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuka_tate : MonoBehaviour
{
    int horizon = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 37)
        {
            horizon = -1;
        }

        if (transform.position.y <= 6)
        {
            horizon = 1;
        }

        transform.Translate(new Vector3(0, horizon, 0) * Time.deltaTime * 2);


    }
}
