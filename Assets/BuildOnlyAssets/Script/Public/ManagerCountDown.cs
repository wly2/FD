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
* 功能描述：     ...............倒计时................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerCountDown : MonoSingleton<ManagerCountDown>
{
    public GameObject text;
   public int TotalTime = 10;
    [HideInInspector] public bool isHezhaTip = true;//判断合闸还是辅电开关完毕
    [HideInInspector] public bool iskKaiche = false;//判断开车
    private void Awake()
    {

    
    } 
    void Start()
    {
       

    }

    private void Update()
    {
       
        ///打开辅电完毕
        if (TotalTime == 1 && isHezhaTip == false)
        {
            ManagerUIScreen.instance.objCountDown.SetActive(false);

            ManagerUIScreen.instance.txtTipScreen.text = Assets.Scripts.BridgeGameStepTip.TIPFUDIAN_1;

           
        }

        ///打开合闸完毕
        if (TotalTime == 1 && isHezhaTip)
        {
            ManagerUIScreen.instance.objCountDown.SetActive(false);

            ManagerUIScreen.instance.txtTipScreen.text = Assets.Scripts.BridgeGameStepTip.TIPHEZHA_1;
        }

        if (TotalTime == 1 && iskKaiche == true)
        {
            ManagerUIScreen.instance.objCountDown.SetActive(false);
            ManagerGame.instance.txtTip.text = BridgeGameStepTip.TIP1;
            ManagerUIScreen.instance.txtTipScreen.text = Assets.Scripts.BridgeGameStepTip.TIPKAICHE_1;

            CinemachineController.instance.CVcamera[15].gameObject.SetActive(false);
            CinemachineController.instance.CVcamera[14].gameObject.SetActive(true);

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public enum typeCountDownTip
    {
        fudian = 0,
        hezha = 2,
    }

    /// <summary>
    /// 倒计时
    /// </summary>
    /// <returns></returns>
    public IEnumerator CountDown()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;

        }
    }
}