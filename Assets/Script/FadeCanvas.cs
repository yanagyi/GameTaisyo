﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeCanvas : MonoBehaviour
{

    [System.NonSerialized]
    public bool fadeIn = false;
    [System.NonSerialized]
    public bool fadeOut = false;

    [SerializeField]
    Image panelImage;

    //フェードのスピード
    [SerializeField]
    float fadeSpeed = 0.02f;

    float red, green, blue, alpha;

    // Start is called before the first frame update
    void Start()
    {
        //シーンが変わってもこのオブジェクトは消さないように
        DontDestroyOnLoad(this.gameObject);

        //元の色を取得
        red = panelImage.color.r;
        green = panelImage.color.g;
        blue = panelImage.color.b;
        alpha = panelImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn)
        {
            FadeIn();
        }
        else if (fadeOut)
        {
            FadeOut();
        }
    }

    //フェードイン
    void FadeIn()
    {
        alpha += fadeSpeed;

        SetAlpha();

        if (alpha >= 1)
        {
            fadeIn = false;
        }
    }

    //フェードアウト
    void FadeOut()
    {
        alpha -= fadeSpeed;

        SetAlpha();

        if (alpha <= 0)
        {
            fadeOut = false;

            Destroy(gameObject);
        }
    }

    //透明度を変更
    void SetAlpha()
    {
        panelImage.color = new Color(red, green, blue, alpha);
    }
}
