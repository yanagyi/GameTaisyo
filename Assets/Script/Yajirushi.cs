using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yajirushi : MonoBehaviour
{
    //矢印の座標コンポーネントの定義
    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        //矢印の座標コンポーネント取得
        rectTransform = GetComponent<RectTransform>();

        //最初は矢印がリトライの横に
        rectTransform.anchoredPosition = new Vector2(-767.0f, -253.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //右を押すと
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("joystick button 9"))
        {
            //矢印がタイトルの横に
            rectTransform.anchoredPosition = new Vector2(329.0f, -253.0f);
        }
        //左を押すと
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("joystick button 8")) 
        {

            //矢印がリトライの横に
            rectTransform.anchoredPosition = new Vector2(-767.0f, -253.0f);
        }
    }
}
