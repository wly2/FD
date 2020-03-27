using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;
using AssemblyCSharp;

public class ManagerGame : MonoSingleton<ManagerGame>
{
    public Text txtTip;


    public GameObject Player;//玩家位置
    public GameObject objBridge;//桥梁环境模型

    //=============搭建完的桥梁模型==========//
    public GameObject objBriFoot;//脚架
    public List<GameObject> objReBriFoot = new List<GameObject>();//原脚架
    public List<GameObject> objDoneBriFoot = new List<GameObject>();//排放好的脚架
    public GameObject objBrige;//桥梁
    public GameObject objBriPulley;//皮带
    public List<GameObject> objBriHuaKuai = new List<GameObject>();//滑块
    public static int brideUIGameStep = 0;//顶部UI步骤
    //=====================选中模型提示===================//
    public GameObject objSaomiaofa;//扫描阀
    public GameObject objConnectSaimiaofa;//连接扫描阀线
    public GameObject objConnectComputer;//连接电脑线

    public GameObject objCRH2;//列车CRH2
    public GameObject obj380A;//列车380A

    //=============搭建前桥梁模型==========//
    public GameObject goReBriPiDai;
    public List<GameObject> objReBri = new List<GameObject>();

    //*************************控制台按钮提示效果************************//
    public GameObject objKeyControl;
    public GameObject objKeyComputer;
    public GameObject objKeyFuDian;
    public GameObject objKeyDong;

    [HideInInspector] public bool isCRH = true;//判断选择的车型

    public GameObject goModelCedian;
    public GameObject goMainCamera;//
    public GameObject goDoneBridge;
    public List<GameObject> goDoneBridgePos = new List<GameObject>();

    /// <summary>
    /// 0脚架提示
    /// 1
    /// </summary>
    public List<GameObject> goTipPrefab = new List<GameObject>();

    /// <summary>
    /// 0脚架摄像机
    /// </summary>
    public List<GameObject> goCamera = new List<GameObject>();
    public GameObject goDoneFoot;

    public static int gameProgress = 0;//游戏进程

    public GameObject goaniBridgeFoot;
    public GameObject goaniBridgeBridge;



    private void Awake()
    {
        txtTip.text = BridgeGameStep.STEP1;
        UIWindow.instance.ShowUI();
    }


    void Update()
    {
        // GameStart();
        //GameStep();
        if (TimeLineController.instance.playablyDirector.initialTime == 7)
        {

            TimeLineController.instance.playablyDirector.Pause();
        }


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
        if (something.CompareTag("zonejiaojia"))
        {
            ManagerGame.gameProgress = 1;

            MyDebug.Log("*************选中脚架，将脚架移动到正确位置******************");
            txtTip.text = "选中脚架，安装脚架";
            objReBriFoot[0].GetComponent<cakeslice.Outline>().enabled = true;
            ShowCamera(0);
            HideTipPreFab(0);
        }


        if (something.CompareTag("zonepidai"))
        {
            MyDebug.Log("*************触发皮带位置******************");
            goReBriPiDai.GetComponent<cakeslice.Outline>().enabled = true;
            HideTipPreFab(1);
            ManagerGame.instance.ShowCamera(1);
        }

        if (something.CompareTag("zoneBridge"))
        {
            MyDebug.Log("*************触发桥梁位置******************");
            goReBriPiDai.GetComponent<cakeslice.Outline>().enabled = true;
            HideTipPreFab(2);
            ShowCamera(2);
            objReBri[0].GetComponent<cakeslice.Outline>().enabled = true;
        }

        //
        if (something.CompareTag("zonehuaikuai"))
        {
            MyDebug.Log("*************触发滑块位置******************");
            for (int i = 0; i < objBriHuaKuai.Count; i++)
            {
                objBriHuaKuai[i].GetComponent<cakeslice.Outline>().enabled = true;
            }
           
            HideTipPreFab(3);
            ShowCamera(3);
            objBriHuaKuai[0].GetComponent<cakeslice.Outline>().enabled = true;
        }


        
    }


    /// <summary>
    /// NPC视角
    /// </summary>
    /// <param name="camearaNum"></param>
    public void ShowCamera(int cameraNum)
    {
        goCamera[cameraNum].SetActive(true);
    }

    /// <summary>
    /// 玩家视角
    /// </summary>
    /// <param name="cameraNum"></param>
    public void HideCamera(int cameraNum)
    {
        goCamera[cameraNum].SetActive(false);
    }

    /// <summary>
    /// 显示提示预设
    /// </summary>
    /// <param name="tipPrefabNum"></param>
    public void ShowTipPreFab(int tipPrefabNum)
    {
        goTipPrefab[tipPrefabNum].SetActive(true);
    }

    /// <summary>
    /// 隐藏提示预设
    /// </summary>
    /// <param name="tipPrefabNum"></param>
    public void HideTipPreFab(int tipPrefabNum)
    {
        goTipPrefab[tipPrefabNum].SetActive(false);
    }

    /// <summary>
    /// 提示预设高光效果
    /// </summary>
    /// <param name="tipPrefabNum"></param>
    public void ShowTipPreFabOutLine(int tipPrefabNum)
    {
        goTipPrefab[tipPrefabNum].GetComponent<cakeslice.Outline>().enabled = true;
    }

    /// <summary>
    /// 隐藏提示预设高光效果
    /// </summary>
    /// <param name="tipPrefabNum"></param>
    public void HideTipPreFabOutLine(int tipPrefabNum)
    {
        goTipPrefab[tipPrefabNum].GetComponent<cakeslice.Outline>().enabled = false;
    }
}
