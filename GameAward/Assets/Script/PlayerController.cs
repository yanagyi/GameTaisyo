using System.Collections;
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
            this.transform.localScale = new Vector3(x -= 0.0005f, y -= 0.0005f, 0);
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

            this.transform.localScale = new Vector3(x += 0.3f, y += 0.3f, 0);

           

            if (x >= 1.0f|| y >= 1.0f)
            {
                this.transform.localScale = new Vector3(1.0f, 1.0f, 0);
            }
           
        }
    }

}
