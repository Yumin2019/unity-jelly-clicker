using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3[] PointList;
    public RuntimeAnimatorController[] LevelAc;

    public Sprite[] JellySpriteList;
    public string[] JellyNameList;
    public int[] JellatinList;
    public int[] JellyGoldList;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
