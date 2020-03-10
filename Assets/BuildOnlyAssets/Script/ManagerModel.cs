using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Assets.Scripts;
#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.0611      10:43
* 功能描述：     ...............管理场景所有模型的提示效果................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerModel : MonoSingleton<ManagerModel>
{
    [HideInInspector] Camera CameraBuXiuGang;
    [HideInInspector] public Ray ray;
    [HideInInspector] public RaycastHit hitInfo;
    public List<GameObject> objCedian = new List<GameObject>();

    private void Awake()
    {
       
    }

    private void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian1" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中测点1***********************");
            for (int i = 0; i < objCedian.Count; i++)
            {
                objCedian[0].gameObject.SetActive(false);
            }
        }
        else if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian2" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中测点2***********************");
            for (int i = 0; i < objCedian.Count; i++)
            {
                objCedian[1].gameObject.SetActive(false);
            }
        }
        else if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "cedian3" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中测点3***********************");
            for (int i = 0; i < objCedian.Count; i++)
            {
                ManagerUI.instance.imgInstallFaTi.gameObject.SetActive(true);
                ManagerUI.instance.imgPiTuoGuan.gameObject.SetActive(false);
                objCedian[2].gameObject.SetActive(false);
                ManagerGame.instance.txtTip.text = FaTiStep.STEP1;
            }


        }

        ///======================搭建桥梁环境=======================//
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "jiaojia" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中脚架==============");
            ManagerGame.instance.objReBriFoot.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.BuilBridgeStep(1);
            //};

        }
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "pidai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中皮带==============");
            //if (ManagerGame.instance.objReBriFoot.GetComponent<Outline>().enabled = true)
            //{
            ManagerAni.instance.BuilBridgeStep(2);
            //};

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "bridge" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中桥梁==============");
            //if (ManagerGame.instance.objReBriFoot.GetComponent<Outline>().enabled = true)
            //{
            ManagerAni.instance.BuilBridgeStep(3);
            //};

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "huakuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中滑块==============");
            //if (ManagerGame.instance.objReBriFoot.GetComponent<Outline>().enabled = true)
            //{
            ManagerAni.instance.BuilBridgeStep(4);
            //};

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "crh2" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中crh2==============");
            //if (ManagerGame.instance.objReBriFoot.GetComponent<Outline>().enabled = true)
            //{
            ManagerAni.instance.BuilBridgeStep(5);
            //};

        }

    }
}
