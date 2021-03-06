﻿using System.Collections;
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
* 功能描述：     ...............场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class SDcontrolAni : MonoSingleton<SDcontrolAni>
{
    public Animator ani;

    void FinishInsSD()
    {
        MeetingControlGame.instance.txtTip.text = "隧道完成。选中车头区域，布置车头测点。";
        suidao.instance.camSuidao[0].SetActive(false);

        MeetingControlUI.instance.goPannelCedian.SetActive(true);
        MeetingControlUI.instance.goPannelCedianPos.SetActive(true);
        MeetingControlGame.instance.txtTip.text = "搭建桥梁完成。选中车头区域，布置车头测点。";
    }
}