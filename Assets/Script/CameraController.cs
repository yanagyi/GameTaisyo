using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // 玉のオブジェクト

    private Vector3 offset; // 玉からカメラまでの距離

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        //BACKボタンが押されたらゲーム終了（PC版の時はESCキー）
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 6"))
        {
            Application.Quit();
        }
    }
}