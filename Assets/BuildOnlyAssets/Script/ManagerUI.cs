
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 20200303    13:13
* 功能描述：     ...............UI逻辑实现................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion
public class ManagerUI : MonoSingleton<ManagerUI>
{
    public GameObject UI;
    public Image imgLabMode;//实验相关
    public Image imgLabAbout;//实验相关
    public Image imgTipPop;//提示框
    public Image imgTrainType;//选择车型
    public Image imgLabAboutPop;//实验相关弹出框
    public GameObject imgBridgeStep;//搭建桥梁工具框
    public Image imgPiTuoGuan;//皮托管

    public GameObject imgBriLabAbout;//桥梁实验实验相关
    public GameObject imgBriLabAboutContent;//实验相关内容弹出框
    public GameObject imgShiYanYuanliContent;//实验原理内容
    public GameObject imgShiMuDiContent;//实验目的内容
    public GameObject objLabSheBei;//实验设备

    public Image imgInstallFaTi;//安装阀体
    public Image imgCeyaMoKuai;//安装测压模块

    public List<GameObject> imgBriUIGameStep = new List<GameObject>();//顶部UI


    void Start()
    {
        // UI.SetActive(false);
    }

    void Update()
    {
        //UIBtnClick();
        bridgeUIGameStep();
    }

    public void LabType(string labtype)
    {
        switch (labtype)
        {
            case "学习模式":
                imgTrainType.gameObject.SetActive(true);
                imgLabMode.gameObject.SetActive(false);
                ManagerGame.brideUIGameStep = 1;
                break;
            case "考核模式":
                break;
        }
    }

    /// <summary>
    /// 点击UI按钮响
    /// </summary>
    public void UIBtnClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !imgLabAbout.gameObject.activeSelf)
        {
            if (!imgBriLabAbout.gameObject.activeSelf)
            {
                imgLabAbout.gameObject.SetActive(true);
            }
            else imgLabAbout.gameObject.SetActive(false);

        }

        else if (Input.GetKeyDown(KeyCode.Escape) && imgLabAbout.gameObject.activeSelf)
        {
            imgLabAbout.gameObject.SetActive(false);
        }
        else return;
    }

    /// <summary>
    /// 实验相关弹出框
    /// </summary>
    public void UIBtnLabAboutPop(string btnName)
    {
        switch (btnName)
        {
            case "实验目的":

                imgShiMuDiContent.gameObject.SetActive(true);
                imgLabAboutPop.gameObject.SetActive(true);
                imgShiYanYuanliContent.gameObject.SetActive(false);
                objLabSheBei.SetActive(false);

                break;

            case "实验原理":
                imgLabAboutPop.gameObject.SetActive(true);
                imgShiYanYuanliContent.gameObject.SetActive(true);
                imgShiMuDiContent.gameObject.SetActive(false);
                objLabSheBei.SetActive(false);
                break;
            case "预习报告":
                break;
            case "实验设备":
                AssemblyCSharp.MyDebug.Log("实验设备");
                objLabSheBei.SetActive(true);
                imgShiYanYuanliContent.gameObject.SetActive(false);
                imgShiMuDiContent.gameObject.SetActive(false);
                break;

            case "设置":
                break;
        }
    }

    /// <summary>
    /// 选择实验类型
    /// </summary>
    public void UIBtnLabType(string labName)
    {
        switch (labName)
        {
            case "明线":
                break;
            case "隧道":
                break;
            case "桥梁":
                ManagerGame.instance.objBridge.SetActive(true);
                imgLabAbout.gameObject.SetActive(false);
                imgTipPop.gameObject.SetActive(true);

                imgBriLabAbout.gameObject.SetActive(true);
                imgLabAbout.gameObject.SetActive(false);
                //imgTrainType.gameObject.SetActive(true);
                break;
            case "交会":
                break;

        }
    }

    /// <summary>
    /// 提示框按钮
    /// </summary>
    public void UIBtnTipPop(string btnName)
    {
        switch (btnName)
        {
            case "CRH2":
                imgBriUIGameStep[1].GetComponent<Text>().color = Color.red;
                ManagerGame.instance.objReBriFoot.GetComponent<cakeslice.Outline>().enabled = true;

                ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP2;
                imgTrainType.gameObject.SetActive(false);
                break;
            case "380A":
                break;
            case "下一步":
                imgBriLabAbout.gameObject.SetActive(false);
                imgTrainType.gameObject.SetActive(true);
                ManagerGame.instance.txtTip.text = "选择车型";
                break;


            case "安装脚架":
                AssemblyCSharp.MyDebug.Log("======安装脚架==========");
                ManagerAni.instance.BuilBridgeStep(1);
                ManagerGame.instance.objReBriFoot.GetComponent<cakeslice.Outline>().enabled = false;
                break;
            case "安装皮带":
                AssemblyCSharp.MyDebug.Log("======安装皮带==========");
                ManagerAni.instance.BuilBridgeStep(2);
                break;
            case "安装桥梁":
                AssemblyCSharp.MyDebug.Log("======安装桥梁==========");
                ManagerAni.instance.BuilBridgeStep(3);
                break;
            case "安装滑块":
                AssemblyCSharp.MyDebug.Log("======安装滑块==========");
                ManagerAni.instance.BuilBridgeStep(4);
                break;

            case "安装列车":
                AssemblyCSharp.MyDebug.Log("======安装列车==========");
                ManagerAni.instance.BuilBridgeStep(5);
                break;

            case "选择皮托管":
                imgPiTuoGuan.gameObject.SetActive(false);
                break;
            case "安装阀体":
                ManagerAni.instance.ani.SetBool("installFati", true);
                break;
            case "安装测压模块":
                ManagerAni.instance.ani.SetBool("insCeYaMoKuai", true);
                break;
        }
    }

    /// <summary>
    /// 顶部UI逻辑
    /// </summary>
    public void bridgeUIGameStep()
    {
        switch (ManagerGame.brideUIGameStep)
        {
            case 0:
                imgBriUIGameStep[0].GetComponent<Text>().color = Color.red;
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
        }
    }
}
