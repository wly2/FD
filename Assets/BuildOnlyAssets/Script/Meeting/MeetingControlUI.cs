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

public class MeetingControlUI : MonoSingleton<MeetingControlUI>
{

    public GameObject goPannelCedian;//测点
    public GameObject goPannelCedianPos;//测点位置
    public GameObject goPannelPituoguan;//皮托管
    public GameObject goPannelVdong;//动模型启动速度
    public List<GameObject> goStepUI = new List<GameObject> ();//顶部步骤UI

    public void btnOnclick(string btnName)
    {

        switch (btnName)
        {
            case "皮托管":
                goPannelCedian.SetActive(false);
                goPannelPituoguan.SetActive(false);

                MeetingManagerGame.instance.ShowManagerCamera(7);//跳转扫描阀
                MeetingControlGame.instance.goSaomiaofa.GetComponent<cakeslice.Outline>().enabled = true;
                MeetingControlGame.instance.txtTip.text = "测点布置完成。选中高亮部分，连接阀体";

                break;
        }
    }
}