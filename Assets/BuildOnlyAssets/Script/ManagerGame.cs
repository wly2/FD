using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class ManagerGame : MonoSingleton<ManagerGame>
{
    public Text txtTip;
    public GameObject Player;//玩家位置
    public GameObject objBridge;//桥梁环境模型

    //=============搭建完的桥梁模型==========//
    public GameObject objBriFoot;//脚架
    public GameObject objReBriFoot;//原脚架
    public GameObject objBrige;//桥梁
    public GameObject objBriPulley;//皮带
    public List<GameObject> objBriHuaKuai = new List<GameObject>();//滑块
    public static int brideUIGameStep = 0;//顶部UI步骤

    //=============搭建前桥梁模型==========//
    public GameObject[] objReBriPiDai = new GameObject[2];
    public GameObject objReBri;

    private void Awake()
    {
        txtTip.text = BridgeGameStep.STEP1;
    }


    void Update()
    {
        // GameStart();
        //GameStep();
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
    /// 操作室视角
    /// </summary>
    public void PlayerPos1()
    {
        Player.transform.position = new Vector3(7.694f, 4.651f, -51.482f);
    }

    /// <summary>
    /// 实验室视角
    /// </summary>
    public void PlayerPos2()
    {
        Player.transform.position = new Vector3(6.24004f, 839173f, -37.812f);
    }


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider something)
    {
        print("================触发桥梁工况环境===============");
        objReBriFoot.GetComponent<Outline>();
        
        //GetComponent<Outline>().enabled = !GetComponent<Outline>().enabled;
        //objReBriFoot.GetComponent<>
    }
}
