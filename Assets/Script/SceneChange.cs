using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //スペースキーが押されたかの判定
    private bool spaceKeyTrue = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スペースが１回押されたら
        if(Input.GetKeyDown(KeyCode.Space) && spaceKeyTrue == false)
        {
            //スペースキーが押された判定（オブジェクト多重動作の防止）
            spaceKeyTrue = true;

            //ステージ１に移行
            FadeManager.Instance.LoadScene("stage1", 1.0f);
        }
    }
}
