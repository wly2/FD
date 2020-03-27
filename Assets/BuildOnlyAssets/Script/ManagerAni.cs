using Assets.Scripts;
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
* Date : 2019.0605    14:12
* 功能描述：     ...............动画管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerAni : MonoSingleton<ManagerAni>
{
    public Animator ani;


    private void Awake()
    {
        ani.GetComponent<Animator>();
    }
    /// <summary>
    ///搭建桥梁环境步骤
    /// </summary>
    /// <param name="buildBrideStep"></param>
    public void BuilBridgeStep(int buildBrideStep)
    {
        switch (buildBrideStep)
        {
            case 1:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画1=========");

                break;
            case 2:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画2=========");
               // ani.SetBool("briStep2", true);
                break;
            case 3:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画3=========");
                //ani.SetBool("briStep3", true);
                break;
            case 4:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画4=========");
               ManagerGame.instance.goaniBridgeBridge.GetComponent<ManagerAni>().ani.SetBool("briStep4", true);
                break;
            case 5:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画5=========");
                ManagerGame.instance.goaniBridgeBridge.GetComponent<ManagerAni>().ani.SetBool("briStep5", true);
                break;

            case 6:
                AssemblyCSharp.MyDebug.Log("=======正在搭建380A动画=========");
                ani.SetBool("build380A", true);
                break;
        }
    }

    public void AniStep(string btnName)
    {
        switch (btnName)

        {

        }
    }

    void FinishBriFoot1()
    {
        ManagerGame.instance.objReBriFoot[1].GetComponent<cakeslice.Outline>().enabled = true;
        ManagerGame.instance.goCamera[0].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = ManagerGame.instance.objReBriFoot[1].transform;

        ManagerGame.instance.objDoneBriFoot[0].SetActive(true);
        ManagerGame.instance.objReBriFoot[0].SetActive(false);
    }

    void FinishBriFoot2()
    {
        ManagerGame.instance.objDoneBriFoot[1].SetActive(true);
        ManagerGame.instance.objReBriFoot[1].SetActive(false);

        ManagerGame.instance.objReBriFoot[2].GetComponent<cakeslice.Outline>().enabled = true;
        ManagerGame.instance.goCamera[0].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = ManagerGame.instance.objReBriFoot[2].transform;
    }

    void FinishBriFoot3()
    {
        ManagerGame.instance.goDoneFoot.SetActive(true);
        ManagerGame.instance.HideCamera(0);
        ManagerGame.instance.objDoneBriFoot[2].SetActive(true);

        for (int i = 0; i < ManagerGame.instance.objReBriFoot.Count; i++)
        {
            ManagerGame.instance.objReBriFoot[i].SetActive(false);
        }
        ManagerGame.instance.txtTip.text = "脚架安装完成，移动到皮带位置";
        ManagerGame.instance.ShowTipPreFab(1);
        ManagerGame.instance.ShowTipPreFabOutLine(1);

    }




    void FinsihInsPidai()
    {

        ManagerGame.instance.objBriPulley.SetActive(true);
        ManagerGame.instance.txtTip.text = BridgeStep.STEP3;
        ManagerGame.instance.goReBriPiDai.SetActive(false);
        ManagerGame.instance.HideCamera(1);

        ManagerGame.instance.ShowTipPreFab(2);
        ManagerGame.instance.ShowTipPreFabOutLine(2);
    }

    /// <summary>
    /// 安装第一块桥梁结束
    /// </summary>
    void FinishBridge1()
    {
        ManagerGame.instance.goDoneBridgePos[0].SetActive(true);
        ManagerGame.instance.goCamera[2].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = ManagerGame.instance.objReBri[1].transform;
        ManagerGame.instance.objReBri[1].GetComponent<cakeslice.Outline>().enabled = true;
        //CinemachineController.instance.CVcamera[8].gameObject.SetActive(true);
        //CinemachineController.instance.CVcamera[0].gameObject.SetActive(false);

        //TimeLineController.instance.Play();
        //ManagerGame.instance.objReBri.SetActive(false);
        //ManagerAni.instance.ani.SetBool("briStep3", false);
        //ManagerGame.instance.txtTip.text = BridgeStep.STEP4;
        //ManagerGame.instance.objBrige.SetActive(true);

        //for (var i = 0; i < ManagerGame.instance.objBriHuaKuai.Count; i++)
        //{
        //    ManagerGame.instance.objBriHuaKuai[i].GetComponent<cakeslice.Outline>().enabled = true;
        //}
    }

    void FinishBridege2()
    {
        for (int i = 0; i < ManagerGame.instance.objReBri.Count; i++)
        {
            ManagerGame.instance.objReBri[i].SetActive(false);
        }
        ManagerGame.instance.goDoneBridge.SetActive(true);
        ManagerGame.instance.goDoneBridgePos[1].SetActive(false);

        ManagerGame.instance.HideCamera(2);
        ManagerGame.instance.ShowTipPreFab(3);
        ManagerGame.instance.ShowTipPreFabOutLine(3);
        
    }

    /// <summary>
    /// 滑轮安装结束
    /// </summary>
    void FinishBriStep4()
    {
        ManagerGame.instance.HideCamera(3);
        ManagerGame.instance.ShowCamera(4);

        ManagerGame.instance.txtTip.text = BridgeStep.STEP5;
        if (ManagerGame.instance.isCRH)
        {
            ManagerGame.instance.objCRH2.GetComponent<cakeslice.Outline>().enabled = true;
         
            for (var i = 0; i < ManagerGame.instance.objBriHuaKuai.Count; i++)
            {
                ManagerGame.instance.objBriHuaKuai[i].SetActive(true);
            }
        }

        else if (!ManagerGame.instance.isCRH)
        {
            CinemachineController.instance.CVcamera[17].gameObject.SetActive(true);
            CinemachineController.instance.CVcamera[8].gameObject.SetActive(false);
            ManagerGame.instance.obj380A.GetComponent<cakeslice.Outline>().enabled = true;
        }


    }

    void FinishBriStep5()
    {
        ManagerGame.instance.txtTip.text = "布置车头测点!";
        //ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[2].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[9].gameObject.SetActive(false);
        //..........跳转到布置测点
        ManagerGame.instance.goModelCedian.SetActive(true);
        ManagerCeDian.instance.goPanelCedian.SetActive(true);
    }

    /// <summary>
    /// 380A动画
    /// </summary>
    void Finish380A()
    {
        ManagerGame.instance.txtTip.text = CeDianStep.STEP1;
        ManagerUI.instance.imgBridgeStep.gameObject.SetActive(false);
        ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(true);
        ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(true);
    }

    void FinisgInstallFati()
    {
        ManagerGame.instance.txtTip.text = FaTiStep.STEP2;
        CinemachineController.instance.CVcamera[11].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[10].gameObject.SetActive(false);

        ManagerGame.instance.objSaomiaofa.GetComponent<cakeslice.Outline>().enabled = true;
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP4;
    }

    public void FinishCeya()
    {
        CinemachineController.instance.CVcamera[12].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[11].gameObject.SetActive(false);
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP5;
    }

    void ceyaConnectFati()
    {
        ManagerGame.instance.objConnectComputer.GetComponent<cakeslice.Outline>().enabled = true;
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP6;
    }

    public void FinishComputer()

    {
        CinemachineController.instance.CVcamera[13].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[12].gameObject.SetActive(false);
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP7;

        ManagerUI.instance.imgBriUIGameStep[4].GetComponent<Text>().color = Color.blue;
    }

    //==========================操作室动画=======================//
    /// <summary>
    /// 控制台加电动画结束
    /// </summary>
    void FinishKeyControl()
    {
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP8;
    }

    /// <summary>
    /// 控制计算机动画结束
    /// </summary>
    void FinishKeyComputer()
    {
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP9;
        CinemachineController.instance.CVcamera[15].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[13].gameObject.SetActive(false);
    }

    /// <summary>
    /// 辅电允许动画结束
    /// </summary>
    void FinishKeyFudian()
    {
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP11;
        CinemachineController.instance.CVcamera[15].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[13].gameObject.SetActive(false);

        ManagerUIScreen.instance.panelTip.SetActive(true);
    }

    /// <summary>
    /// 动模型动画结束
    /// </summary>
    void FinishkeyDong()

    {
        ManagerUIScreen.instance.objControlScreen.SetActive(true);

    }

    /// <summary>
    /// crh2动模型动画结束
    /// </summary>
    void FinishCRh2Dong()

    {
        ManagerGame.instance.txtTip.text = BridgeGameStep.STEP14;
        CinemachineController.instance.CVcamera[15].gameObject.SetActive(true);
        CinemachineController.instance.CVcamera[16].gameObject.SetActive(false);

        ManagerUIScreen.btnPress = 1;

        ManagerGame.instance.objKeyFuDian.GetComponent<cakeslice.Outline>().enabled = true;

        ManagerUI.instance.imgBriUIGameStep[6].GetComponent<Text>().color = Color.blue;
    }
}
