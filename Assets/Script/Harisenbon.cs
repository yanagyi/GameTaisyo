using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Harisenbon : MonoBehaviour
{
    //インスペクターからの画像設定
    public Sprite NormalSprite;
    public Sprite OkoSprite;

    //通常状態かおこ状態かのフラグ
    private bool Oko;

    //最大時間の定義（インスペクターから変更可）
    [SerializeField] private float maxTime = 5.0f;

    //計測時間の定義
    private float measurementTime = 1.0f;

    //スプライトレンダラーのコンポーネント定義
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        //スプライトレンダラーのコンポーネント取得
        this.sr = GetComponent<SpriteRenderer>();
        GetComponent<CircleCollider2D>().enabled = false;

        //最初は通常状態
        sr.sprite = NormalSprite;
        Oko = false;
    }

    // Update is called once per frame
    void Update()
    {
        //ハリセンボン通常状態
        if(Oko == false)
        {
            //ハリセンボンの画像を通常状態に
            sr.sprite = NormalSprite;

            //当たり判定をオフ状態に
            GetComponent<CircleCollider2D>().enabled = false;

            //時間計測
            measurementTime += Time.deltaTime;

            //時間が経過したらおこ状態に
            if (maxTime <= measurementTime)
            {
                //時間をリセット
                measurementTime = 0f;
                Oko = true;

            }

        }

        //ハリセンボンおこ状態
        if (Oko == true)
        {
            //ハリセンボンの画像をおこ状態に
            sr.sprite = OkoSprite;

            //当たり判定をオン状態に
            GetComponent<CircleCollider2D>().enabled = true;

            //時間計測
            measurementTime += Time.deltaTime;

            //時間が経過したら通常状態に
            if (maxTime <= measurementTime)
            {
                //時間をリセット
                measurementTime = 0f;
                Oko = false;
            }
        }
    }
}
