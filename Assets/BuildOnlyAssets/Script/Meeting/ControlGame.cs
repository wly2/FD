using AssemblyCSharp;
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
* 功能描述：     ...............场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ControlGame : MonoSingleton<ControlGame>
{
    public Text txtTip;
    public GameObject goBridgeFoot;

    public List<GameObject> goTip = new List<GameObject>();

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
        txtTip.text = MeetingStep.TIP1;
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zonejiaojia"))
        {
            MyDebug.Log("***********进入脚架触发区***********  ");
            goBridgeFoot.GetComponent<cakeslice.Outline>().enabled = true;
            ManagerAllGame.instance.HideTipPreFab(0);
            ManagerAllGame.instance.ShowManagerCamera(0);
            txtTip.text = MeetingStep.TIP2;
        }
    }

}

