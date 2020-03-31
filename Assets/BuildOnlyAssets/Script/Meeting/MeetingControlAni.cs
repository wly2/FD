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

public class MeetingControlAni : MonoSingleton<MeetingControlAni>
{
    [HideInInspector] public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }


    void FinishInsFoot1()
    {
        //MeetingManagerGame.instance.HideManagerCamera(0);
        MeetingControlGame.instance.goDoneFoot[0].SetActive(true);
        MeetingControlGame.instance.goBridgeFoot[0].SetActive(false);

        MeetingControlGame.instance.goBridgeFoot[1].GetComponent<cakeslice.Outline>().enabled = true;
        MeetingControlGame.instance.goCamera[0].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = MeetingControlGame.instance.goBridgeFoot[1].transform;
    }

    void FinishInsFoot2()
    {
        MeetingControlGame.instance.goDoneFoot[1].SetActive(true);
        MeetingControlGame.instance.goBridgeFoot[1].SetActive(false);

        MeetingControlGame.instance.goBridgeFoot[2].GetComponent<cakeslice.Outline>().enabled = true;
        MeetingControlGame.instance.goCamera[0].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = MeetingControlGame.instance.goBridgeFoot[2].transform;
    }

    void FinishInsFoot3()
    {
        MeetingControlGame.instance.goDoneFoot[2].SetActive(true);
        MeetingControlGame.instance.goBridgeFoot[2].SetActive(false);
        MeetingControlGame.instance.goBridgeFoot[3].SetActive(false);

        MeetingManagerGame.instance.ShowTipPreFab(1);
        MeetingManagerGame.instance.HideManagerCamera(0);

       MeetingControlGame.instance.txtTip.text = "脚架搭建完毕。移动到皮带位置!";
    }

    void FinishInspidai()
    {
        MeetingManagerGame.instance.HideManagerCamera(1);

        MeetingManagerGame.instance.ShowTipPreFab(2);
        MeetingControlGame.instance.goDonePidai.SetActive(true);
        MeetingControlGame.instance.goPidai.SetActive(false);

        MeetingControlGame.instance.txtTip.text = "皮带安装完成，移动到桥梁位置!";

    }

    void FinishBridge1()
    {
        MeetingControlGame.instance.goCamera[2].GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = MeetingControlGame.instance.goBridge[1].transform;
        MeetingControlGame.instance.goBridge[1].GetComponent<cakeslice.Outline>().enabled = true;

        MeetingControlGame.instance.goBridge[0].SetActive(false);
        MeetingControlGame.instance.goDoneBridge[0].SetActive(true);
    }

    void FinishBridge2()
    {
        MeetingControlGame.instance.goBridge[1].SetActive(false);
        MeetingControlGame.instance.goBridge[2].SetActive(false);
        MeetingControlGame.instance.goDoneBridge[1].SetActive(true);

        MeetingManagerGame.instance.HideManagerCamera(2);
        MeetingManagerGame.instance.ShowTipPreFab(3);

        MeetingControlGame.instance.txtTip.text = "移动到滑块位置，安装列车滑块!";
    }

        void FinishLeftHuaikuai()
    {
        MeetingManagerGame.instance.HideManagerCamera(3);
        MeetingManagerGame.instance.ShowManagerCamera(4);

        MeetingControlGame.instance.goCRH2[0].GetComponent<cakeslice.Outline>().enabled = true;
        MeetingControlGame.instance.txtTip.text = "滑块安装完成，选中列车，安装列车!";
    }

    void FinishInsLeftCrh2()
    {
        MeetingManagerGame.instance.HideManagerCamera(4);
        //MeetingControlGame.instance.goDoneCrh2[0].SetActive(true);//

        MeetingManagerGame.instance.ShowTipPreFab(4);
        MeetingControlGame.instance.txtTip.text = "移动至滑块位置，再次安装滑块";
    }

    void FinishRightHuaikuai()
    {
        MeetingManagerGame.instance.HideManagerCamera(5);
        MeetingManagerGame.instance.ShowManagerCamera(6);

        MeetingControlGame.instance.goCRH2[1].GetComponent<cakeslice.Outline>().enabled = true;
        MeetingControlGame.instance.txtTip.text = "选中列车，再次安装列车";
}

    void FinishRightCrh2()
    {
        //完成桥梁搭建
        MeetingControlUI.instance.goStepUI[0].GetComponent<Text>().color = Color.green;

        ///隧道工况
        if (suidao.instance.isSuidao == true)
        {
            MeetingControlGame.instance.txtTip.text = "移至隧道旁，安装隧道!";
            MeetingManagerGame.instance.ShowTipPreFab(7);
            MeetingManagerGame.instance.HideManagerCamera(6);
        }

        ///交会工况
         if (Meeting.instance.isMeeting == true)
        {
            MeetingControlGame.instance.txtTip.text = "搭建桥梁完成。选中车头区域，布置车头测点。";
            MeetingManagerGame.instance.HideManagerCamera(6);

            MeetingControlUI.instance.goPannelCedian.SetActive(true);
            MeetingControlUI.instance.goPannelCedianPos.SetActive(true);
            MeetingControlGame.instance.txtTip.text = "搭建桥梁完成。选中车头区域，布置车头测点。";
        }
      
    }


    void FinishInsFati()
    {
        MeetingManagerGame.instance.HideManagerCamera(7);
        MeetingManagerGame.instance.ShowManagerCamera(8);

        MeetingControlGame.instance.goceyamokuaia.GetComponent<cakeslice.Outline>().enabled = true;
        MeetingControlGame.instance.txtTip.text = "选中测压模块，连接测压模块";
    }

    void FinishCeyamokuai()
    {
        MeetingManagerGame.instance.HideManagerCamera(8);
        MeetingManagerGame.instance.ShowTipPreFab(5);

        MeetingControlGame.instance.txtTip.text = "移至桌子位置，连接阀体";
    }

    void FinishLineCeYa()
    {
        MeetingManagerGame.instance.HideManagerCamera(9);

        MeetingManagerGame.instance.ShowTipPreFab(6);

        //完成连接阀体
        MeetingControlUI.instance.goStepUI[2].GetComponent<Text>().color = Color.green;
        MeetingControlGame.instance.txtTip.text = "移至操作台位置，启动动模型!";
    }

    void FinishConControlKei()
    {
        MeetingControlUI.instance.goPannelVdong.SetActive(true);
        //完成启动动模型
        MeetingControlUI.instance.goStepUI[3].GetComponent<Text>().color = Color.green;

        MeetingControlGame.instance.txtTip.text = "输入动模型启动速度!";
    }


}
