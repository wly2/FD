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

    public GameObject ComputerScreen;


    private void Awake()
    {
        //StartCoroutine(base.Start());
        //OverView();
    }

    

    //public void lookAtModel(string model)
    //{
    //    switch (model)
    //    {
    //        case "CRH2":
    //            // base.LookAtTarget = traCRH2;
    //            base.LookAtAppointTarget();
    //            break;
    //    }
    //}
    
    public void NearControlBox()
    {
        CameraLookAt.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
        base.LookAtTarget = traControlBox;
        base.LookAtAppointTarget();
        ManagerGame.instance.txtTip.text = ConfigPath.STEP2;
        Debug.Log("正在跳转操作箱");
    }

    public void NearComputer()
    {
        CameraLookAt.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
        base.LookAtTarget = traComputer;
        base.LookAtAppointTarget();
       
        Debug.Log("正在跳转显示屏");

        ComputerScreen.GetComponent<MeshRenderer>().material.color = Color.white;
        ManagerGame.instance.txtTip.text = ConfigPath.STEP5;
    }




}
