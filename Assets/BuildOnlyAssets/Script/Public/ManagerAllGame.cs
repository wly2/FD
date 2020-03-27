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
* 功能描述：     ...............场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerAllGame : MonoSingleton<ManagerAllGame>
{
    /// <summary>

    /// </summary>
    /// <param name="isGoTip">显示隐藏提示预设体</param>
    /// <param name="CountTip">哪个提示预设体</param>
    public void ShowTipPreFab(int CountTip)
    {
        ControlGame.instance.goTip[CountTip].SetActive(true);
    }

    public void HideTipPreFab(int CountTip)
    {
        ControlGame.instance.goTip[CountTip].SetActive(false);
    }

    public void ShowManagerCamera(int CameraCount)

    {
        ControlGame.instance.goCamera[CameraCount].SetActive(true);
    }

    public void HideManagerCamera(int CameraCount)

    {
        ControlGame.instance.goCamera[CameraCount].SetActive(false);
    }
}