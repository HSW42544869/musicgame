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

    private float score = 0;
    private AudioClip aud1;
    private AudioClip aud2;
    private AudioSource As;
    private Rigidbody2D rig;
    private Animator ani;
    /// <summary>
    /// 跳躍
    /// </summary>
    void Jump()
    {

    }
    /// <summary>
    /// 攻擊
    /// </summary>
    void attack()
    {

    }
    /// <summary>
    /// 受到傷害
    /// </summary>
    /// <param name="damage"></param>
    void heat(float damage)
    {

    }
    void dead()
    {

    }
    void Addscore(float score)
    {

    }
}
