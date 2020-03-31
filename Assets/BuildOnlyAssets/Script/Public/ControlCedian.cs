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

public class ControlCedian : MonoBehaviour
{
    [HideInInspector] public Ray ray;
    [HideInInspector] public RaycastHit hitInfo;

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian1" && Input.GetMouseButtonDown(0))
        //{
        //    AssemblyCSharp.MyDebug.Log("**************************选中测点1***********************");
        //    for (int i = 0; i <ManagerCeDian.instance.objCedian.Count; i++)
        //    {
        //        ManagerCeDian.instance.objCedian[0].gameObject.SetActive(false);
        //    }
        //}
        //if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian2" && Input.GetMouseButtonDown(0))
        //{
        //    AssemblyCSharp.MyDebug.Log("**************************选中测点2***********************");
        //    for (int i = 0; i < ManagerCeDian.instance.objCedian.Count; i++)
        //    {
        //        ManagerCeDian.instance.objCedian[1].gameObject.SetActive(false);
        //    }
        //}
        //if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian3" && Input.GetMouseButtonDown(0))
        //{
        //    AssemblyCSharp.MyDebug.Log("**************************选中测点3***********************");
        //    for (int i = 0; i < ManagerCeDian.instance.objCedian.Count; i++)
        //    {
        //        ManagerUI.instance.imgInstallFaTi.gameObject.SetActive(true);
        //        ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(false);
        //        ManagerCeDian.instance.objCedian[2].gameObject.SetActive(false);
        //       // ManagerGame.instance.txtTip.text = FaTiStep.STEP1;
        //    }
        //}


        //==============================测点布置==================================//
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("cdhead") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============布置车头测点==============");
            ManagerCeDian.instance.Modelchetou.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerCeDian.instance.ShowCeDianInput();

            ManagerCeDian.cedianPos = 1;
        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("cdchewei") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============布置车尾测点==============");
            ManagerCeDian.instance.Modelchewei.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerCeDian.instance.ShowCeDianInput();

            ManagerCeDian.cedianPos = 2;
        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("cdcheshen") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============布置车身测点==============");
            ManagerCeDian.instance.Modelcheshen.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerCeDian.instance.ShowCeDianInput();

            ManagerCeDian.cedianPos = 3;
        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("cdscheshen") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============布置上车身测点==============");
            ManagerCeDian.instance.Modelscheshen.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerCeDian.instance.ShowCeDianInput();

            ManagerCeDian.cedianPos = 4;
        }


        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("cdxcheshen") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============布置下车身测点==============");
            ManagerCeDian.instance.Modelxcheshen.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerCeDian.instance.ShowCeDianInput();

            ManagerCeDian.cedianPos = 5;
            ///测点布置完成
            MeetingControlUI.instance.goPannelPituoguan.SetActive(true);
            MeetingControlUI.instance.goPannelCedianPos.SetActive(false);
        }
    }
}