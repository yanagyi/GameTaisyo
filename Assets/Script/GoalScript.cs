﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    //シーンチェンジクラス生成
    public StageChange stageChange;

    //プレイヤーがゴールに触れたかの判定の変数
    private bool playerGoalTouch;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーがまだゴールに触れていない判定
        playerGoalTouch = false;
        
        //シーンチェンジのコンポーネント取得
        stageChange = GameObject.Find("StageChange").GetComponent<StageChange>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //プレイヤーがゴールに触れると
        if (other.gameObject.tag == "Player" && playerGoalTouch == false)
        {
            //プレイヤーがゴールに触れた判定
            playerGoalTouch = true;

            //次のステージに移行
            stageChange.NextStage();
        }
    }
}
