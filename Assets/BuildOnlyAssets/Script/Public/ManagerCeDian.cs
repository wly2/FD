﻿using AssemblyCSharp;
using System;
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
* 功能描述：     ...............场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerCeDian : MonoSingleton<ManagerCeDian>
{
    public GameObject CDchetou;//车头
    public GameObject CDchewei;//车尾
    public GameObject CDcheshen;//车身
    public GameObject CDscheshen;//上车身
    public GameObject CDxcheshen;//下车身

    public GameObject Modelchetou;//车头
    public GameObject Modelchewei;//车尾 
    public GameObject Modelcheshen;//车身
    public GameObject Modelscheshen;//上车身
    public GameObject Modelxcheshen;//下车身
    public GameObject goPanelCedianInput;

    public List<GameObject> objCedian = new List<GameObject>();

    /// <summary>
    /// 0
    /// 1
    /// 2
    /// 3
    /// 4
    /// </summary>
    public List<GameObject> goCamCedeian = new List<GameObject>();
    
    /// <summary>
    /// 1车头
    /// 2车尾
    /// 3车身
    /// 4上车身
    /// 5下车身
    /// </summary>
    [HideInInspector]public static int cedianPos = 0;
    public Text txtCedian;//面板测点数


    private void FixedUpdate()
    {
        //int cedianNum = Convert.ToInt32(txtCedian.text);
    }

    /// <summary>
    /// 显示测点输入框
    /// </summary>
    public void ShowCeDianInput()

    {
        goPanelCedianInput.SetActive(true);
    }

    /// <summary>
    /// 隐藏测点输入框
    /// </summary>
    public void HideCeDianInput()

    {
        goPanelCedianInput.SetActive(false);
    }

    public void MakeSure()
    {
        //车头
        if (cedianPos == 1 && Convert.ToInt32(txtCedian.text) < 50)
        {
            MyDebug.Log("************车头测点数不能少于50个**************");
            MeetingControlGame.instance.txtTip.text = "车头测点数不能少于50个！";
        }
        else
        {
            if (cedianPos == 1 && Convert.ToInt32(txtCedian.text) >= 50)
            {
                MeetingControlGame.instance.txtTip.text = "车头测点布置成功!布置车尾测点";
                HideCeDianInput();
                CDchetou.SetActive(true);
            }

        }


        //车尾
        if (cedianPos == 2 && Convert.ToInt32(txtCedian.text) < 50)
        {
            MyDebug.Log("************车尾测点数不能少于50个**************");
            MeetingControlGame.instance.txtTip.text = "车尾测点数不能少于50个！";
        }
        else
        {
            if (cedianPos == 2 && Convert.ToInt32(txtCedian.text) >= 50)
            {
                MeetingControlGame.instance.txtTip.text = "车尾测点布置成功!布置车身测点";
                HideCeDianInput();
                CDchewei.SetActive(true);
            }

        }


        //车身
        if (cedianPos == 3 && Convert.ToInt32(txtCedian.text) < 6)
        {
            MyDebug.Log("************车身测点数不能少于6个**************");
            MeetingControlGame.instance.txtTip.text = "车身测点数不能少于6个！";
        }
        else
        {
            if (cedianPos == 3 && Convert.ToInt32(txtCedian.text) >= 6)
            {
                MeetingControlGame.instance.txtTip.text = "车身测点布置成功!布置上车身测点";
                HideCeDianInput();
                CDcheshen.SetActive(true);
            }

        }

        //上车身
        if (cedianPos == 4 && Convert.ToInt32(txtCedian.text) < 6)
        {
            MyDebug.Log("************上车身测点数不能少于6个**************");
            MeetingControlGame.instance.txtTip.text = "上车身测点数不能少于6个！";
        }
        else
        {
            if (cedianPos == 4 && Convert.ToInt32(txtCedian.text) >= 6)
            {
                MeetingControlGame.instance.txtTip.text = "上车身测点布置成功!不知下车身测点";
                HideCeDianInput();
                CDscheshen.SetActive(true);
            }

        }


        //下车身
        if (cedianPos == 5 && Convert.ToInt32(txtCedian.text) < 6)
        {
            //MyDebug.Log("************上车身测点数不能少于6个**************");
            MeetingControlGame.instance.txtTip.text = "下车身测点数不能少于6个！";
        }
        else
        {
            if (cedianPos == 5 && Convert.ToInt32(txtCedian.text) >= 6)
            {
                MeetingControlGame.instance.txtTip.text = "下车身测点布置成功!选择皮托管，连接阀体";
                HideCeDianInput();
                CDxcheshen.SetActive(true);
                MeetingControlUI.instance.goPannelCedianPos.SetActive(false);

                ///完成测点布置
                MeetingControlUI.instance.goStepUI[1].GetComponent<Text>().color = Color.green;
            }

        }
    }

    public void PannelRightCeDian(string btnName)
    {
        switch (btnName)
        {
            case "车头":

                goCamCedeian[0].gameObject.SetActive(true);
                goCamCedeian[1].gameObject.SetActive(false);
                goCamCedeian[2].gameObject.SetActive(false);
                goCamCedeian[3].gameObject.SetActive(false);
                goCamCedeian[4].gameObject.SetActive(false);

                if (!CDchetou.activeSelf)
                {
                    Modelchewei.GetComponent<cakeslice.Outline>().enabled = true;
                }
                //for (int i = 0; i < CinemachineController.instance.CVcamera.Count; i++)
                //{
                //    CinemachineController.instance.CVcamera[i].gameObject.SetActive(false);
                //}
                break;

            case "车尾":

                goCamCedeian[0].gameObject.SetActive(false);
                goCamCedeian[1].gameObject.SetActive(true);
                goCamCedeian[2].gameObject.SetActive(false);
                goCamCedeian[3].gameObject.SetActive(false);
                goCamCedeian[4].gameObject.SetActive(false);

                if (!CDchewei.activeSelf)
                {
                    Modelchewei.GetComponent<cakeslice.Outline>().enabled = true;
                }
               
                cedianPos = 2;
                break;

            case "车身":
                goCamCedeian[0].gameObject.SetActive(false);
                goCamCedeian[1].gameObject.SetActive(false);
                goCamCedeian[2].gameObject.SetActive(true);
                goCamCedeian[3].gameObject.SetActive(false);
                goCamCedeian[4].gameObject.SetActive(false);

                if (!CDcheshen.activeSelf)
                {
                    Modelcheshen.GetComponent<cakeslice.Outline>().enabled = true;
                }
                cedianPos = 3;
                break;

            case "上车身":
                goCamCedeian[0].gameObject.SetActive(false);
                goCamCedeian[1].gameObject.SetActive(false);
                goCamCedeian[2].gameObject.SetActive(false);
                goCamCedeian[3].gameObject.SetActive(true);
                goCamCedeian[4].gameObject.SetActive(false);

                if (!CDscheshen.activeSelf)
                {
                    Modelscheshen.GetComponent<cakeslice.Outline>().enabled = true;
                }
                cedianPos = 4;
                break;

            case "下车身":
                goCamCedeian[0].gameObject.SetActive(false);
                goCamCedeian[1].gameObject.SetActive(false);
                goCamCedeian[2].gameObject.SetActive(false);
                goCamCedeian[3].gameObject.SetActive(false);
                goCamCedeian[4].gameObject.SetActive(true);

                //ManagerUI.instance.imgBriUIGameStep[2].GetComponent<Text>().color = Color.blue;

                if (!CDxcheshen.activeSelf)
                {
                    Modelxcheshen.GetComponent<cakeslice.Outline>().enabled = true;
                 
                }
                cedianPos = 5;
                break;

        }
    }


}