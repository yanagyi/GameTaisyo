using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDestory : MonoBehaviour
{
   
    [SerializeField] private int direction = 1;
    [SerializeField] private float seconds = 3.0f;

    



    // Start is called before the first frame update
    void Start()
    {

       

        Destroy(transform.gameObject, seconds);//三秒後Destory

        
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (direction == 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 2);//上
        }

        if (direction == 1)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 2);//下
        }

        if (direction == 2)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2);//左
        }

        if (direction == 3)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);//右
        }

    }

    



}
