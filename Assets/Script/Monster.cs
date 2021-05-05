using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("跳躍高度"),Range(0,3000)]
    public int jump = 100;
    [Header("血量"),Range(0,200)]
    public int live = 500;
    public bool infloot = false;

    private int score = 0;
    private AudioClip aud1;
    private AudioClip aud2;
    private AudioSource As;
    private Rigidbody2D rig;
    private Animator ani;

}
