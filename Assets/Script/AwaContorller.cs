﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaContorller : MonoBehaviour
{
    public float speed = 10; // 動く速さ

    public Rigidbody2D awa; // Rididbody
    private float x = 3.0f;
    private float y = 3.0f;




    void Start()
    {
        // Rigidbody を取得
        awa = GetComponent<Rigidbody2D>();



    }

    void Update()
    {



        if (x >= 3.0f)
        {
            x = 3.0f;
        }
        if (y >= 3.0f)
        {
            y = 3.0f;
        }

        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // カーソルキーの入力に合わせて水平移動方向を設定

        if (moveVertical != 0 && x >= 0 && y >= 0 && awa.velocity.y >= 0)
        {
            this.transform.localScale = new Vector3(x -= 0.0005f, y -= 0.0005f, 0);
        }
        var movement = new Vector3(moveHorizontal * 2, moveVertical * 2, 0);

        // Ridigbody に力を与えて玉を動かす
        awa.AddForce(movement * speed);


        //重力
        // Physics2D.gravity = new Vector3(0, -15, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);

            this.transform.localScale = new Vector3(x += 0.3f, y += 0.3f, 0);



            if (x >= 3.0f || y >= 3.0f)
            {
                this.transform.localScale = new Vector3(3, 3, 0);
            }

        }



    }

}