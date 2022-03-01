﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2Controller : MonoBehaviour
{
    private Vector3 latestPos;  //前回のPosition

    private void Start()
    {
        latestPos = transform.position;
    }

    private void Update()
    {
        Vector3 diff = transform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        latestPos = transform.position;  //前回のPositionの更新

        //ベクトルの大きさが0.01以上の時に向きを変える処理をする
        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff); //向きを変更する
        }
    }
}
