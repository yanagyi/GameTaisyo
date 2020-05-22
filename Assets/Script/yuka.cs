using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuka : MonoBehaviour
{
    int vector = 1;

    // Start is called before the first frame update
    void Start()
    {

      


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 1.40f)
        {
            vector = -1;
        }

        if (transform.position.x <= -17)
        {
            vector = 1;
        }

        transform.Translate(new Vector3(vector, 0, 0) * Time.deltaTime * 2);


        }

   

}
