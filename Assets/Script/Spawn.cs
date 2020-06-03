using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //キューブ一個生成のタイマーと間隔
    private float timerOne = 1.0f;
    private float timeOne = 1.0f;
    //キューブのウェーブ生成のタイマーと間隔
    private float timerWave = 0.0f;
    private float timeWave = 10.0f;
    //キューブのウェーブの数量とプレハブ
    private int countPerWave = 0;
    public GameObject spawnPerfab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeWave += Time.deltaTime;
        if (timerWave < timeWave && countPerWave != 5000)//ウェーブ生成のタイマーと数量
        {
            timerOne += Time.deltaTime * 13;             //(speed)
            if (timerOne > timeOne)                      //一個生成のタイマーと位置
            {
                Instantiate(spawnPerfab, new Vector3(Random.Range(this.transform.position.x - 3.0f, this.transform.position.x + 3.0f), this.transform.position.y, 
                    0), 
                    spawnPerfab.transform.rotation);

                countPerWave++;
                timerOne -= timeOne;
            }
        }

        if (timerWave >= timeWave)
        {
            timerWave -= timeWave;
            countPerWave = 0;
        }

    }
}
