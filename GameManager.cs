using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 使用 UI 物件，必須增加此處理程序

public class GameManager : MonoBehaviour
{
    GameObject car;              // 用來儲存汽車物件
    GameObject flag;             // 用來儲存旗子物件
    GameObject distance;         // 用來儲存UI文字物件
    GameObject score;      // 用來儲存分數文字物件
    GameObject y;             // 用來儲存空物件

    void Start() // 將場景中的物件放到已宣告的各個物件中
    {
        car = GameObject.Find("car");         
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        score=GameObject .Find("score");
        y = GameObject.Find("y");

    }

    void Update()
    {
        // 計算旗子與汽車的距離
        float length = flag.transform.position.x - car.transform.position.x;
        // 將旗子與汽車的距離顯示在UI上面
        distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + "m";
        // 計算空物件與汽車的距離
        float eu = car.transform.position.x - y.transform.position.x+ flag.transform.position.x;
        float i = 0;

        if (eu >= 14.9f || eu < 0)
        {
            i = 100 / length;
            if (i > 100)
                i = 100;

        }
        else
        {
            i = 0;
        }
        float x = car.transform.position.x - y.transform.position.x + flag.transform.position.x;
        float u = 0;

        if (eu >= 6.90f || eu < 0)
        {
            x = 100 / length;
            if (u > 100)
                u = 100;

        }
        else
        {
            u = 0;
        }
        score.GetComponent<Text>().text = "分數 " + u.ToString("F2") + "分";
    }
}

