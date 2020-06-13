using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour
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
        //STARTボタンが１回押されたら（PC版の時はスペースキー）
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 7") && spaceKeyTrue == false)
        {
            Debug.Log("推された");
            //スペースキーが押された判定（オブジェクト多重動作の防止）
            spaceKeyTrue = true;

            //ステージ１に移行
            SceneManager.LoadScene("TitleScene");
        }

        //BACKボタンが押されたらゲーム終了（PC版の時はESCキー）
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 6"))
        {
            Application.Quit();
        }
    }
}
