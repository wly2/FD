
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

    [SerializeField] GameObject objPanelSetting;
    [SerializeField] GameObject objPanelHelp;
    [SerializeField] GameObject objPanelShebei;
    [SerializeField] GameObject objPanelMudi;
    [SerializeField] GameObject objPanelYuanli;

    public GameObject panelData;
    public GameObject panelCentre;//

    public GameObject panelCeDianInput;//测点输入框

    private void Awake()
    {
        imgTrainType.gameObject.SetActive(true);
    }

    void Update()
    {
        //UIBtnClick();
        //bridgeUIGameStep();
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

                ManagerGame.instance.txtTip.text = "已选择CRH2车型，移动到桥梁脚架位置";
                ManagerGame.instance.isCRH = true;
                imgBriUIGameStep[1].GetComponent<Text>().color = Color.blue;
                ManagerGame.instance.ShowTipPreFabOutLine(0);
                imgTrainType.gameObject.SetActive(false);

                UIWindow.instance.ShowUI();


                break;
            case "380A":
                ManagerGame.instance.isCRH = false;
                imgBriUIGameStep[1].GetComponent<Text>().color = Color.blue;
                ManagerGame.instance.objReBriFoot[0].GetComponent<cakeslice.Outline>().enabled = true;

                ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP2;
                imgTrainType.gameObject.SetActive(false);

                UIWindow.instance.ShowUI();
                break;
            case "下一步":
                imgBriLabAbout.gameObject.SetActive(false);
                imgTrainType.gameObject.SetActive(true);
                ManagerGame.instance.txtTip.text = "选择车型";
                break;
            case "皮托管":
                imgBriUIGameStep[3].GetComponent<Text>().color = Color.blue;
                ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP3;
                imgPiTuoGuan.gameObject.SetActive(false);

                if (ManagerGame.instance.isCRH)
                {
                    ManagerGame.instance.objSaomiaofa.GetComponent<cakeslice.Outline>().enabled = true;

                    CinemachineController.instance.CVcamera[10].gameObject.SetActive(true);
                    CinemachineController.instance.CVcamera[9].gameObject.SetActive(false);
                    CinemachineController.instance.CVcamera[2].gameObject.SetActive(false);
                    imgBriUIGameStep[3].GetComponent<Text>().color = Color.blue;
                    ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP3;

                    ///
                    panelCeDianInput.SetActive(false);
                    MeetingControlUI.instance.goPannelCedian.SetActive(false);//关闭测点
                    ManagerGame.instance.goModelCedian.SetActive(false);
                }
                if (!ManagerGame.instance.isCRH)
                {
                    CinemachineController.instance.CVcamera[18].gameObject.SetActive(true);
                    CinemachineController.instance.CVcamera[17].gameObject.SetActive(false);
                    CinemachineController.instance.CVcamera[9].gameObject.SetActive(false); 
                }
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
    /// 左边UI按钮
    /// </summary>
    public void PanelLeft(string btnName)
    {
        bool isPree = true;
        switch (btnName)
        {
            case "实验原理":
                if (!objPanelYuanli.activeSelf)
                {
                    objPanelYuanli.SetActive(true);
                }
                else objPanelYuanli.SetActive(false);

                break;

            case "实验目的":
                if (!objPanelMudi.activeSelf)
                {
                    objPanelMudi.SetActive(true);
                }
                else objPanelMudi.SetActive(false);

                break;

            case "实验设备":
                if (!objPanelShebei.activeSelf)
                {
                    objPanelShebei.SetActive(true);
                }
                else objPanelShebei.SetActive(false);
                break;

            case "帮助":
                if (!objPanelHelp.activeSelf)
                {
                    objPanelHelp.SetActive(true);
                }
                else objPanelHelp.SetActive(false);
                break;

            case "设置":
                print("=============点击设置====================");
                if (!objPanelSetting.activeSelf)
                {
                    objPanelSetting.SetActive(true);
                }
                else objPanelSetting.SetActive(false);
                //Transform.Find("");
                //GameObject hp_bar = (GameObject)Instantiate(Resources.Load("PanelLeft/prefabSetting"));
                //GameObject mUICanvas = GameObject.Find("Canvas/Panel_Centre");
                //hp_bar.transform.parent = mUICanvas.transform;
                break;
        }
    }



}
