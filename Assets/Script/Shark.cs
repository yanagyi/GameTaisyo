using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    //サメは最初右移動
    private bool m_xPlus = true;

    //サメの移動する速度（インスペクターから変更可能）
    [SerializeField] private float sharkSpeed = 5.0f;

    //サメの移動する横幅の最大値（インスペクターから変更可能）
    [SerializeField] private float sharkMovementWidthRight = 5.0f;
    [SerializeField] private float sharkMovementWidthLeft = -5.0f;

    //スプライトレンダラーのコンポーネント定義
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        //スプライトレンダラーのコンポーネント取得
        this.sr = GetComponent<SpriteRenderer>();

        //サメの向きは最初右向き
        sr.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        //サメが右移動
        if(m_xPlus == true)
        {
            //サメを右向きに
            sr.flipX = true;

            //サメが移動する距離
            transform.position += new Vector3(sharkSpeed * Time.deltaTime, 0f, 0f);

            //サメが一定値移動したら左移動
            if (transform.position.x >= sharkMovementWidthRight )
                m_xPlus = false;          
        }

        //サメが左移動
        if(m_xPlus == false)
        {
            //サメを左向きに
            sr.flipX = false;

            //サメが移動する距離
            transform.position -= new Vector3(sharkSpeed * Time.deltaTime, 0f, 0f);

            //サメが一定値移動したら右移動
            if (transform.position.x <= sharkMovementWidthLeft)
                m_xPlus = true;
        }
    }
}
