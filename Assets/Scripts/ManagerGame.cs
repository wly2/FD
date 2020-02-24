using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class ManagerGame : MonoSingleton<ManagerGame>
{
    public Text txtTip;
    public GameObject Player;//玩家位置



    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        GameStart();
    }


    public void GameStart()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            txtTip.text = ConfigPath.STEP1;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {

        }

    }

    /// <summary>
    /// 操作室
    /// </summary>
    public void PlayerPos1()
    {
        Player.transform.position = new Vector3(7.694f, 4.651f, -51.482f);
    }

    /// <summary>
    /// 实验室
    /// </summary>
    public void PlayerPos2()
    {
        Player.transform.position = new Vector3(6.24004f, 839173f, -37.812f);
    }

}
