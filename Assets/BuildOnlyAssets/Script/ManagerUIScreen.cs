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
* 功能描述：     ...............电脑显示屏UI管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerUIScreen : MonoSingleton<ManagerUIScreen>
{
    public GameObject panelSoft;//软件
    public GameObject panelTip;//电压提示操作框

    public Text txtV;//加压值
    public Text txtTipScreen;//电脑显示屏提示

    public GameObject objCountDown;
    public GameObject objControlScreen;//控制台屏幕

    public Button btnFuDian;
    public Button btnHeZha;
    public Button btnKaiChe;
    public Button btnExit;
    public static int btnPress = 0;//按钮按下

    private void Update()
    {
        if (txtV.text == 0.5.ToString())
        {
           
        }

        //if (ManagerCountDown.instance.TotalTime == 1)
        //{
        //    ManagerUIScreen.instance.objCountDown.SetActive(false);

        //    ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStepTip.TIPFUDIAN_1;
        //}

    }

    public void btnOnclick(string btnName)
    {
        switch (btnName)
        {
            case "电脑软件":
                panelSoft.SetActive(false);
                CinemachineController.instance.CVcamera[15].gameObject.SetActive(false);
                CinemachineController.instance.CVcamera[13].gameObject.SetActive(true);
                ManagerGame.instance.objKeyFuDian.GetComponent<cakeslice.Outline>().enabled = true;
                ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP10;

                break;

            case "打开辅电":
                    print("****************打开辅电按钮************");
                    ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP12;
                    txtTipScreen.text = BridgeGameStepTip.TIPFUDIAN;
                    objCountDown.SetActive(true);
                    ManagerCountDown.instance.isHezhaTip = false;
                    btnFuDian.transform.Find("Text").GetComponent<Text>().text = "关辅电";
                    StartCoroutine(ManagerCountDown.instance.CountDown());

                ///关辅电
                if (btnFuDian.transform.Find("Text").GetComponent<Text>().text == "关辅电" && btnPress == 1)
                {
                    print("按下关辅电键");
                    ManagerGame.instance.txtTip.text = "4)	将操作箱上的铺电开关旋转至关闭位置";

                    ///镜头切换至操作箱
                    //CinemachineController.instance.CVcamera[13].gameObject.SetActive(true);
                    //CinemachineController.instance.CVcamera[15].gameObject.SetActive(false);
                    ///采集数据
                    ///
                    ManagerUI.instance.panelData.SetActive(true);
                    ManagerUI.instance.panelCentre.SetActive(true);

                }
                break;
                

            case "打开合闸":
               
                if (btnHeZha.transform.Find("Text").GetComponent<Text>().text == "合闸")
                {
                    print("****************打开合闸按钮************");
                    ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStep.STEP13;
                    txtTipScreen.text = BridgeGameStepTip.TIPHEZHA;
                    objCountDown.SetActive(true);
                    ManagerCountDown.instance.isHezhaTip = true;
                    btnHeZha.transform.Find("Text").GetComponent<Text>().text = "闭闸";
                    ManagerCountDown.instance.TotalTime = 10;//重置倒计时
                    StartCoroutine(ManagerCountDown.instance.CountDown());
                }
                ///风洞关机，按下闭闸键
                if (btnHeZha.transform.Find("Text").GetComponent<Text>().text == "闭闸" && btnPress == 1)
                {
                    print("按下闭闸键");
                    ManagerGame.instance.txtTip.text = "一分钟后，点软件中关辅电按钮";

                    ///
                }
                break;

            case "打开开车":
               
                ///跳转至桥梁模型

                if (btnKaiChe.transform.Find("Text").GetComponent<Text>().text == "开车")
                {
                    print("****************打开开车按钮************");
                    ManagerUIScreen.instance.txtTipScreen.text = BridgeGameStepTip.TIPKAICHE;
                    objCountDown.SetActive(true);
                    ManagerCountDown.instance.TotalTime = 5;//重置倒计时
                    StartCoroutine(ManagerCountDown.instance.CountDown());
                    ManagerCountDown.instance.iskKaiche = true;
                    //ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeGameStepTip.TIP1;
                    btnKaiChe.transform.Find("Text").GetComponent<Text>().text = "停车";
                }
               

                ///风洞关机，按下关车键
                if (btnKaiChe.transform.Find("Text").GetComponent<Text>().text =="停车" && btnPress == 1)
                {
                    print("按下关车键");
                    ManagerGame.instance.txtTip.text = "一分钟后，点软件中分闸按钮";
                }
                break;

            case "确认动模型运行速度":///跳转动模型，播放动模型动画
                CinemachineController.instance.CVcamera[14].gameObject.SetActive(false);
                CinemachineController.instance.CVcamera[16].gameObject.SetActive(true);

                ManagerAni.instance.ani.SetBool("crhDong", true);///播放动模型动画

                ManagerUI.instance.imgBriUIGameStep[5].GetComponent<Text>().color = Color.blue;
                break;
        }
    }
}