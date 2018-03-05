﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//アイテムのステータスを保持する
//cloneして使う
public class StatItem : MonoBehaviour
{

    //ステータスの定義
    public string Name = "name";//名前
    public string Image = "image";//イメージのファイル名（.png抜き）
    public int Power = 0;//うまさ
    public Color Col;//色
    public float UpSus = 0;//Sus上昇値
    public float Human = 0;//人由来かどうか

    //ステータス表示オブジェクトの取得
    public GameObject Item;//自分自身
    public Text PowerText;//自分自身


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
