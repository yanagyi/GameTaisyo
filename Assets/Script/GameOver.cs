using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //タイトルかリトライかのフラグ（初期値はリトライ）
    bool retry = true;

    //タイトル戻るときに削除するオブジェクトの定義
    public GameObject stageChangeObject  = GameObject.Find("StageChange");
    public GameObject gameOverCanvasObject = GameObject.Find("GameOverCanvas");

    //シーン定義
    string  name;

    // Start is called before the first frame update
    void Start()
    {
        //シーンを切り替えてもこのゲームオブジェクトを削除しないようにする
        DontDestroyOnLoad(gameObject);

        // 現在のシーン名を取得
        name = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        //右矢印を押すと
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //フラグをタイトルに
            retry = false;
        }
        //左矢印を押すと
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            //フラグをリトライに
            retry = true;
        }

        //フラグがタイトルにあってかつスペースが押されたらタイトルに
        if(retry == false && Input.GetKeyDown(KeyCode.Space))
        {
            //タイトル画面に移行
            SceneManager.LoadScene("TitleScene");
            //ステージチェンジ処理重複するため消す
            Destroy(stageChangeObject);
            Destroy(gameOverCanvasObject);
        }

        //フラグがリトライにあってかつスペースが押されたらリトライ
        if (retry == true && Input.GetKeyDown(KeyCode.Space))
        {
            //ゲームオーバーになったシーンのリトライ
            SceneManager.LoadScene(name);
            //ステージチェンジ処理重複するため消す
            Destroy(stageChangeObject);
            Destroy(gameOverCanvasObject);
        }

    }
}
