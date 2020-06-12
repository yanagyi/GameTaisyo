using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //スペースキーが押されたかの判定
    private bool spaceKeyTrue = false;

    //オーディオの変数
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //オーディオのコンポーネント取得
        audioSource = GetComponent<AudioSource>();

        //BGM鳴らす
        audioSource.PlayOneShot(sound1);
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

        //ESCキーが押されたらゲーム終了
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
