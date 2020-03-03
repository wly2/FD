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
* 功能描述：     ...............动画管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerAni : MonoSingleton<ManagerAni>
{
    public Animator ani;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Finishtake2()
    {
        //ManagerAni.instance.ani.SetBool("istake2", false);
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeStep.TAKE3;

    }

    void Finishtake3()
    {

        //ManagerAni.instance.ani.SetBool("istake3", false);
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeStep.TAKE4;
    }

    void Finishtake4()
    {
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeStep.TAKE5;
        // ManagerAni.instance.ani.SetBool("istake4", false);
    }

    void Finishtake5()
    {
        // ManagerAni.instance.ani.SetBool("istake5", false);
        ManagerGame.instance.txtTip.text = Assets.Scripts.BridgeStep.TAKE6;

    }

    void Finishtake6()
    {

        // ManagerAni.instance.ani.SetBool("istake6", false);
    }
}
