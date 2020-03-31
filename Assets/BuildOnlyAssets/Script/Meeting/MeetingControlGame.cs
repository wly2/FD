using AssemblyCSharp;
using Assets.Scripts;
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
* 功能描述：     ...............交会实验逻辑................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class MeetingControlGame : MonoSingleton<MeetingControlGame>
{
    public Text txtTip;
    public List <GameObject> goBridgeFoot = new List<GameObject>();
    public List<GameObject> goBridge = new List<GameObject>();
    public List<GameObject> goLeftHuaikuai = new List<GameObject>();
    public List<GameObject> goRightHuaikuai = new List<GameObject>();
    public List<GameObject> goCRH2 = new List<GameObject>();
    public GameObject goPidai;

    public List<GameObject> goDoneFoot = new List<GameObject>();
    public List<GameObject> goDoneBridge = new List<GameObject>();
    public GameObject goDonePidai;
   // public List <GameObject> goDoneCrh2 = new List<GameObject> ();

    public List<GameObject> goTip = new List<GameObject>();
    public GameObject goSaomiaofa;//扫描阀
    public GameObject goceyamokuaia;//测压模块
    public GameObject goLineCeya;//测压模块线
    public GameObject goControlKey;
    public Text txtVdong;//动模型运行速度



    /// <summary>
    /// 0脚架摄像机
    /// 2
    /// 3
    /// 4
    /// 5
    /// 6
    /// 7
    /// 8
    /// 9
    /// 10
    /// 11
    /// </summary>
    public List<GameObject> goCamera = new List<GameObject>();

    private void Awake()
    {
        txtTip.text = "移至脚架位置。安装脚架!";
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zonejiaojia"))
        {
            MyDebug.Log("***********进入脚架触发区***********  ");
            goBridgeFoot[0].GetComponent<cakeslice.Outline>().enabled = true;
            MeetingManagerGame.instance.HideTipPreFab(0);
            MeetingManagerGame.instance.ShowManagerCamera(0);
            txtTip.text = "选中脚架，将脚架移至正确位置!";
        }

        if (other.CompareTag("zonepidai"))
        {
            MyDebug.Log("***********进入皮带触发区***********  ");
            goPidai.GetComponent<cakeslice.Outline>().enabled = true;
            MeetingManagerGame.instance.HideTipPreFab(1);
            MeetingManagerGame.instance.ShowManagerCamera(1);
            txtTip.text = "选中皮带，安装皮带!";
        }

        if (other.CompareTag("zoneBridge"))
        {
            MyDebug.Log("***********进入桥梁触发区***********  ");
            goBridge[0].GetComponent<cakeslice.Outline>().enabled = true;
            MeetingManagerGame.instance.HideTipPreFab(2);
            MeetingManagerGame.instance.ShowManagerCamera(2);
            txtTip.text = "选中桥梁，安装桥梁!";
        }
        if (other.CompareTag("zonehuaikuai"))
        {
            MyDebug.Log("***********进入左边滑块触发区***********  ");
            for (int i = 0; i < goLeftHuaikuai.Count; i++)
            {
                goLeftHuaikuai[i].GetComponent<cakeslice.Outline>().enabled = true;
            }
           
            MeetingManagerGame.instance.HideTipPreFab(3);
            MeetingManagerGame.instance.ShowManagerCamera(3);
            txtTip.text = "选择滑块，安装滑块!";
        }

        if (other.CompareTag("tipRightHuakuai"))
        {
            MyDebug.Log("***********进入右边滑块触发区***********  ");
            for (int i = 0; i < goRightHuaikuai.Count; i++)
            {
                goRightHuaikuai[i].GetComponent<cakeslice.Outline>().enabled = true;
            }

            MeetingManagerGame.instance.HideTipPreFab(4);
            MeetingManagerGame.instance.ShowManagerCamera(5);
            txtTip.text = "选择滑块，再次安装滑块!";
        }


        if (other.CompareTag("tipCeya"))
        {
            MyDebug.Log("***********进入连接测压模块触发区***********  ");
            MeetingManagerGame.instance.ShowManagerCamera(9);
            MeetingControlGame.instance.goLineCeya.GetComponent<cakeslice.Outline>().enabled = true;

            MeetingManagerGame.instance.HideTipPreFab(5);
            MeetingControlGame.instance.txtTip.text = "选中阀体连接线，连接阀体!";
        }

        if (other.CompareTag("tipDong"))
        {
            MyDebug.Log("***********进入动模型起动触发区***********  ");
            MeetingManagerGame.instance.ShowManagerCamera(10);
            MeetingControlGame.instance.goControlKey.GetComponent<cakeslice.Outline>().enabled =  true;

            MeetingManagerGame.instance.HideTipPreFab(6);
            txtTip.text = "扭动“钥匙开关”钥匙，启动动模型!";
        }
    }

    /// <summary>
    /// 动模型输入速度
    /// </summary>
    /// <param name="Vdong"></param>
    public void VdongInput()
    {
        MeetingManagerGame.instance.HideManagerCamera(10);
        MeetingManagerGame.instance.ShowManagerCamera(11);
        if (Convert.ToInt32(txtVdong.text) >1 && Convert.ToInt32(txtVdong.text) <5)
        {
            ///播放第一段动模型动画....
            MyDebug.Log("输入启动速度：" + txtVdong.text);
            MeetingControlAni.instance.ani.SetBool("Vdong1", true);

        }

        if (Convert.ToInt32(txtVdong.text) > 5 && Convert.ToInt32(txtVdong.text) < 10)
        {
            ///播放第二段动模型动画....

            MeetingControlAni.instance.ani.SetBool("Vdong2", true);

        }
        if (Convert.ToInt32(txtVdong.text) > 10 && Convert.ToInt32(txtVdong.text) < 15)
        {
            ///播放第三段动模型动画....

            MeetingControlAni.instance.ani.SetBool("Vdong3", true);

        }
        if (Convert.ToInt32(txtVdong.text) > 15 && Convert.ToInt32(txtVdong.text) < 20)
        {
            ///播放第四段动模型动画....

            MeetingControlAni.instance.ani.SetBool("Vdong4", true);

        }
        if (Convert.ToInt32(txtVdong.text) > 20 && Convert.ToInt32(txtVdong.text) < 30)
        {
            ///播放第五段动模型动画....
            MeetingControlAni.instance.ani.SetBool("Vdong5", true);


        }
    }

}

