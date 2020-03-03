
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
* Date : 20200303    13:13
* 功能描述：     ...............UI逻辑实现................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion
public class ManagerUI : MonoBehaviour
{
    public GameObject UI;
    public Image imgLabAbout;//实验相关
    public Image imgLabType;//实验类型


    void Start()
    {
        // UI.SetActive(false);
    }

    void Update()
    {
        UIBtnClick();
    }


    /// <summary>
    /// 点击UI按钮响
    /// </summary>
    public void UIBtnClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !imgLabAbout.gameObject.activeSelf)
        {
            imgLabAbout.gameObject.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && imgLabAbout.gameObject.activeSelf)
        {
            imgLabAbout.gameObject.SetActive(false);
        }
        else return;
    }

    /// <summary>
    /// 实验相关弹出框
    /// </summary>
    public void UIBtnLabAboutPop(string btnName)
    {
        switch (btnName)
        { 
            case "实验目的":
                break;

            case "实验原理":
                break;

            case "虚拟实验":
                imgLabType.gameObject.SetActive(true);
                break;

            case "预习报告":
                break;
            case "实验设备":
                ;
                break;

            case "设置":
                break;
        }
    }
}
