using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    //クラス生成

    //クリアテキストクラス生成
    public GameObject ClearText;
    //シーンチェンジクラス生成
    public StageChange stageChange;

    // Start is called before the first frame update
    void Start()
    {
        //通常時は見えていない
        ClearText.SetActive(false);
        
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
        if(other.gameObject.tag == "Player")
        {
            //クリアのロゴが出現
            ClearText.SetActive(true);

            //次のステージに移行
            stageChange.NextStage();
        }
    }
}
