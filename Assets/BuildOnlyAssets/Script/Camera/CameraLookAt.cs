using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;
using Assets.Scripts;
#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：场景主相机
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.0611    10:42
* 功能描述：     ................第一视角，用于看向物体...............    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class CameraLookAt : ManagerCamera
{
    [SerializeField] Transform traControlBox;//操作箱
    [SerializeField] Transform traComputer;//电脑
    [SerializeField] Transform traCRH2;//CRH
    [SerializeField] Transform traFati;//阀体
    [SerializeField] Transform traCeya;//测压模块
    [SerializeField] Transform traJiaojia;//桥梁脚架

    public GameObject ComputerScreen;


    private void Awake()
    {
        //StartCoroutine(base.Start());
        //OverView();
    }

   
    
    public void NearControlBox()
    {
        CameraLookAt.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
        base.LookAtTarget = traControlBox;
        base.LookAtAppointTarget();
        ManagerGame.instance.txtTip.text = ConfigPath.STEP2;
        MyDebug.Log("正在跳转操作箱");
    }

    public void NearComputer()
    {
        CameraLookAt.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
        base.LookAtTarget = traComputer;
        base.LookAtAppointTarget();

        MyDebug.Log("正在跳转显示屏");

        ComputerScreen.GetComponent<MeshRenderer>().material.color = Color.white;
        ManagerGame.instance.txtTip.text = ConfigPath.STEP5;
    }

    /// <summary>
    /// 看向列车
    /// </summary>
    public void NearCRH2()
    {
        CameraLookAt.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);

        base.LookAtTarget = traCRH2;
        base.LookAtAppointTarget();
    }

    /// <summary>
    /// 看向阀体
    /// </summary>
    public void NearFaTi()
    {
        MainCamera.gameObject.SetActive(false);

        base.LookAtTarget = traFati;
        base.LookAtAppointTarget();
    }

    /// <summary>
    /// 看向测压模块
    /// </summary>
    public void NearCeYa()
    {
        MainCamera.gameObject.SetActive(false);

        base.LookAtTarget = traCeya;
        base.LookAtAppointTarget();
    }

    public void NearJiaojia()
    {
        //base.LookAtTarget = traJiaojia;
        //base.LookAtAppointTarget();
    }


}
