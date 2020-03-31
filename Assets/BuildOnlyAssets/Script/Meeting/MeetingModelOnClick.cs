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

public class MeetingModelOnClick : MonoBehaviour
{
    [HideInInspector] public Ray ray;
    [HideInInspector] public RaycastHit hitInfo;

    private void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "jiaojia" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中脚架1***********************");
            MeetingControlGame.instance.goBridgeFoot[0].GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("installFoot1", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "jiaojia2" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中脚架2***********************");
            MeetingControlGame.instance.goBridgeFoot[1].GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("installFoot2", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "jiaojia3" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中脚架3***********************");
            MeetingControlGame.instance.goBridgeFoot[2].GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("installFoot3", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "pidai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中皮带***********************");
            MeetingControlGame.instance.goPidai.GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insPidai", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "bridge1" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中桥梁1***********************");
            MeetingControlGame.instance.goBridge[0].GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insBridge1", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "bridge2" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中桥梁2***********************");
            MeetingControlGame.instance.goBridge[1].GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insBridge2", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "huakuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中左边滑块***********************");
            for (int i = 0; i <MeetingControlGame.instance.goLeftHuaikuai.Count; i++)
            {
                MeetingControlGame.instance.goLeftHuaikuai[i].GetComponent<cakeslice.Outline>().enabled = false;
            }
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insLeftHuaikuai", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "crh2Left" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中左边列车***********************");
          
            MeetingControlGame.instance.goCRH2[0].GetComponent<cakeslice.Outline>().enabled = false;
           
            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insLeftCrh2", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "rightHuaikuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中右边滑块***********************");

            for (int i = 0; i <MeetingControlGame.instance.goRightHuaikuai.Count; i++)
            {
                MeetingControlGame.instance.goRightHuaikuai[i].GetComponent<cakeslice.Outline>().enabled = false;
            }

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insRightHuaikuai", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "crhRight" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中右边crh2***********************");
            MeetingControlGame.instance.goCRH2[1].GetComponent<cakeslice.Outline>().enabled = false;

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insRightCrh2", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "saomiaofa" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中扫描阀***********************");
            MeetingControlGame.instance.goSaomiaofa.GetComponent<cakeslice.Outline>().enabled = false;

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insFati", true);

        }

        //
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "ceyamokuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中测压模块***********************");
            MeetingControlGame.instance.goceyamokuaia.GetComponent<cakeslice.Outline>().enabled = false;

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("insCeyaomokuai", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "LineCeYa" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中连接测压模块网线***********************");
            MeetingControlGame.instance.goLineCeya.GetComponent<cakeslice.Outline>().enabled = false;

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("conLineCeya", true);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "keyControl" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中启动动模型钥匙***********************");
            MeetingControlGame.instance.goControlKey.GetComponent<cakeslice.Outline>().enabled = false;

            //播放动画....
            MeetingControlAni.instance.ani.SetBool("onKeyControl", true);
            //MeetingControlGame.instance.goControlKey.transform.rotation = new Quaternion(90f, 0, -158f, 0);

        }
    }



}
    