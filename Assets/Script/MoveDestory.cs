using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestory : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        Destroy(transform.gameObject, 2);//三秒後Destory
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 2);//落下
    }



}
