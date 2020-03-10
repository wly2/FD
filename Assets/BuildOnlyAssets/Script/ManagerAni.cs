using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                ani.SetBool("briStep1", true);
                break;
            case 2:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画2=========");
                ani.SetBool("briStep2", true);
                break;
            case 3:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画3=========");
                ani.SetBool("briStep3", true);
                break;
            case 4:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画4=========");
                ani.SetBool("briStep4", true);
                break;
            case 5:
                AssemblyCSharp.MyDebug.Log("=======正在加载桥梁动画5=========");
                ani.SetBool("briStep5", true);
                break;
        }
    }

    public void AniStep(string btnName)
    {
        switch (btnName)

        {

        }
    }



    void FinishBriStep1()
    {
        ManagerGame.instance.objReBriFoot.SetActive(false);
        ManagerAni.instance.ani.SetBool("briStep1", false);
        ManagerGame.instance.txtTip.text = BridgeStep.STEP2;
        ManagerGame.instance.objBriFoot.SetActive(true);
    }

    void FinishBriStep2()
    {
        int i;
        for (i = 0; i < ManagerGame.instance.objReBriPiDai.Length; i++)
        {
            ManagerGame.instance.objReBriPiDai[i].SetActive(false);
        }

        ManagerGame.instance.objBriPulley.SetActive(true);
        ManagerGame.instance.txtTip.text = BridgeStep.STEP3;
        ManagerAni.instance.ani.SetBool("briStep2", false);
    }

    void FinishBriStep3()
    {
        ManagerGame.instance.objReBri.SetActive(false);
        ManagerAni.instance.ani.SetBool("briStep3", false);
        ManagerGame.instance.txtTip.text = BridgeStep.STEP4;
        ManagerGame.instance.objBrige.SetActive(true);
    }

    void FinishBriStep4()
    {
        //for (int i = 0; i < ManagerGame.instance.objReHuaKuai.Count; i++)
        //{
        //    ManagerGame.instance.objReHuaKuai[i].SetActive(false);
        //}
        for (var i = 0; i < ManagerGame.instance.objBriHuaKuai.Count; i++)
        {
            ManagerGame.instance.objBriHuaKuai[i].SetActive(true);
        }
        ManagerGame.instance.txtTip.text = BridgeStep.STEP5;

    }

    void FinishBriStep5()
    {
        ManagerGame.instance.txtTip.text = CeDianStep.STEP1;
        ManagerUI.instance.imgBridgeStep.gameObject.SetActive(false);
        ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(true);

    }

    void FinisgInstallFati()
    {
        ManagerGame.instance.txtTip.text = FaTiStep.STEP2;
        ManagerUI.instance.imgInstallFaTi.gameObject.SetActive(false);
        ManagerUI.instance.imgCeyaMoKuai.gameObject.SetActive(true);
    }

    void FinishCeya()
    {

    }

    void ceyaConnectFati()
    {

    }
}
