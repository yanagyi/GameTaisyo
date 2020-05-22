
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControlScript : MonoBehaviour
{
    public float speed = 10; // 動く速さ
   
   

    public GameObject awa;

    private Vector3 dis;
   


    void Start()
    {
      

        dis = transform.position - awa.transform.position;

    }

    void Update()
    {

        transform.position = awa.transform.position + dis;

    }
}



