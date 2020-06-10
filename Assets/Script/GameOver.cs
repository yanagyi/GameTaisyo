﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //タイトルかリトライかのフラグ（初期値はリトライ）
    bool retry = true;

    //タイトル戻るときに削除するオブジェクトの変数
    public GameObject stageChangeObject;
    public GameObject gameOverCanvasObject;

    //ステージチェンジのスクリプトの入れる変数
    StageChange script;

    //オーディオの変数
    public AudioClip sound1;
    AudioSource audioSource;

    //シーン変数
    string  name;

    // Start is called before the first frame update
    void Start()
    {
        // 現在のシーン名を取得
        name = SceneManager.GetActiveScene().name;

        //ステージチェンジのスクリプトを取得
        stageChangeObject = GameObject.Find("StageChange");
        script = stageChangeObject.GetComponent<StageChange>();

        //オーディオのコンポーネント取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //右矢印を押すと
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //フラグをタイトルに
            retry = false;

            //効果音鳴らす
            audioSource.PlayOneShot(sound1);
        }
        //左矢印を押すと
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            //フラグをリトライに
            retry = true;

            //効果音鳴らす
            audioSource.PlayOneShot(sound1);
        }

        //フラグがタイトルにあってかつスペースが押されたらタイトルに
        if(retry == false && Input.GetKeyDown(KeyCode.Space))
        {
            //ステージチェンジ処理重複するため消す
            script.DestroyStageChange();

            //タイトル画面に移行
            SceneManager.LoadScene("TitleScene");
        }

        //フラグがリトライにあってかつスペースが押されたらリトライ
        if (retry == true && Input.GetKeyDown(KeyCode.Space))
        {
            //ゲームオーバーになったシーンのリトライ
            SceneManager.LoadScene(name);           
        }

    }
}
