﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10; // 動く速さ

    private Rigidbody rb; // Rididbody
    private float x = 1.0f;
    private float y = 1.0f;




    void Start()
    {
        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //もしtimescaleが止まってるならキー入力を受け付けない
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        if (x >= 1.0f)
        {
            x = 1.0f;
        }
        if (y >= 1.0f)
        {
            y = 1.0f;
        }

        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // カーソルキーの入力に合わせて水平移動方向を設定
        if (moveVertical != 0 && x >= 0 && y >= 0)
        {
            this.transform.localScale = new Vector3(x -0.0005f, y -0.0005f,0);
        }
        var movement = new Vector3(moveHorizontal, moveVertical,0);

        // Ridigbody に力を与えて玉を動かす
        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);

            this.transform.localScale = new Vector3(x += 0.5f, y += 0.5f,0);



            if (x >= 1.0f || y >= 1.0f)
            {
                this.transform.localScale = new Vector3(1.0f, 1.0f,0);
            }

        }
    }

}
