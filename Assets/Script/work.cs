using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class work : MonoBehaviour
{
    [Header("speed"), Range(0, 10)]
    public int sp = 10;
    [Header("attack"), Range(0, 500)]
    public int at = 100;
    [Header("live"), Range(0, 5000)]
    public int lv = 350;
    [Header("掉落物件")]
    public GameObject ga;
    [Header("掉落物件機率"), Range(0, 1)]
    public int inga = 1;
    [Header("掉落道具音效")]
    public AudioClip au;
    [Header("元件 音效來源")]
    private AudioSource aus;
    [Header("元件2D剛體來源")]
    private Rigidbody2D rig2;
    [Header("元件 動畫控制器")]
    public Animator ant;
}
