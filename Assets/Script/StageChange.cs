using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChange : MonoBehaviour
{
    //現在のステージ番号（1始まり）
    [System.NonSerialized]
    public int currentStageNum = 0;

    //ステージ名;
    [SerializeField]
    public string[] stageName;

    [SerializeField]
    GameObject fadeCanvasPrefab;

    //フェード時の待ち時間
    [SerializeField]
    float fadeWaitTime = 1.0f;

    GameObject fadeCanvasClone;
    FadeCanvas fadeCanvas;
 

    // Start is called before the first frame update
    void Start()
    {
        //シーンを切り替えてもこのゲームオブジェクトを削除しないようにする
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //次のステージに進む処理
    public void NextStage()
    {
        currentStageNum += 1;

        //コルーチンを実行
        StartCoroutine(WaitForLoadScene());
    }

    //シーンの読み込みと待機を行うコルーチン
    IEnumerator WaitForLoadScene()
    {
        //フェードオブジェクトを生成
        fadeCanvasClone = Instantiate(fadeCanvasPrefab);

        //コンポーネントを取得
        fadeCanvas = fadeCanvasClone.GetComponent<FadeCanvas>();

        //フェードインさせる
        fadeCanvas.fadeIn = true;

        yield return new WaitForSeconds(fadeWaitTime);

        //シーンを非同期で読込し、読み込まれるまで待機する
        yield return SceneManager.LoadSceneAsync(stageName[currentStageNum]);

        //フェードアウトさせる
        fadeCanvas.fadeOut = true;
    }
}
