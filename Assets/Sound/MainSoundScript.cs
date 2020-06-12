using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSoundScript : MonoBehaviour
{
    //public bool DontDestroyEnabled = false;

        //重複してサウンドオブジェクトができないようにする
    private void Awake()
    {
        int numMainSoundScript = FindObjectsOfType<MainSoundScript>().Length;
        if (numMainSoundScript > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    //void Start()
    //{
    //    if (DontDestroyEnabled)
    //    {
    //        // Sceneを遷移してもオブジェクトが消えないようにする
    //        DontDestroyOnLoad(this);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {

    }
}