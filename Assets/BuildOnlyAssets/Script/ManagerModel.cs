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
* 功能描述：     ...............管理场景所有模型的点击效果................    
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
            for (var i = 0; i < ManagerGame.instance.objReBriPiDai.Length; i++)
            {
                ManagerGame.instance.objReBriPiDai[i].GetComponent<cakeslice.Outline>().enabled = false;
            }
            ManagerAni.instance.BuilBridgeStep(2);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "bridge" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中桥梁==============");
            ManagerGame.instance.objReBri.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.BuilBridgeStep(3);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "huakuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中滑块==============");
            for (var i = 0; i < ManagerGame.instance.objBriHuaKuai.Count; i++)
            {
                ManagerGame.instance.objBriHuaKuai[i].GetComponent<cakeslice.Outline>().enabled = false;
              

            }
            ManagerAni.instance.BuilBridgeStep(4);

        }

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "crh2" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中crh2==============");
            ManagerGame.instance.objCRH2.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.BuilBridgeStep(5);
            //};

        }

        ///380
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "380A" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中380A==============");
            ManagerGame.instance.obj380A.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.BuilBridgeStep(6);
        }

        ///扫描阀
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "saomiaofa" && Input.GetMouseButtonDown(0))
        {
            //ManagerGame.brideUIGameStep = 4;
            AssemblyCSharp.MyDebug.Log("============选中扫描阀==============");
            ManagerGame.instance.objSaomiaofa.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.ani.SetBool("installFati", true);
            //if (ManagerGame.instance.objReBriFoot.GetComponent<Outline>().enabled = true)
            //{
            //ManagerAni.instance.BuilBridgeStep(5);
            //};

        }

        ///测压模块
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "ceyamokuai" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中测压模块==============");
            ManagerGame.instance.objSaomiaofa.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerAni.instance.ani.SetBool("insCeYaMoKuai", true);
        }


        //测压模块连接电子扫描阀
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "connectSaomiaofa" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============测压模块连接至扫描阀==============");
            ManagerAni.instance.ani.SetBool("connectSaomiaofa", true);
            ManagerGame.instance.objConnectSaimiaofa.GetComponent<cakeslice.Outline>().enabled = false
                ;
        }

        //连接电脑
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "connectComputer" && Input.GetMouseButtonDown(0))
        {
            ManagerGame.instance.objConnectComputer.GetComponent<cakeslice.Outline>().enabled = false;
            AssemblyCSharp.MyDebug.Log("============选中电脑连接线==============");
            ManagerAni.instance.ani.SetBool("connectComputer", true);

            //ManagerGame.brideUIGameStep = 5;
        }

        //控制台加电钥匙
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("keyControl") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中控制台加电钥匙==============");
            ManagerGame.instance.objKeyControl.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerGame.instance.objKeyComputer.GetComponent<cakeslice.Outline>().enabled = true;

            ManagerAni.instance.ani.SetBool("keyControl", true);
            ManagerGame.instance.objKeyControl.GetComponent<Animator>().enabled = true;
        }

        //控制台控制计算机钥匙
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("keyComputer") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中控制台控制计算机钥匙==============");
            ManagerGame.instance.objKeyComputer.GetComponent<cakeslice.Outline>().enabled = false;
            ManagerGame.instance.objKeyComputer.GetComponent<Animator>().enabled = true;
           ManagerAni.instance.ani.SetBool("keyComputer", true);
        }



        //打开控制台辅电开关钥匙
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("keyFuDian") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中控制台辅电钥匙==============");
            ManagerGame.instance.objKeyFuDian.GetComponent<cakeslice.Outline>().enabled = false;

            ManagerAni.instance.ani.SetBool("keyFuDian", true);
            ManagerGame.instance.objKeyFuDian.GetComponent<Animator>().enabled = true;
        }

        ///关闭控制台辅电开关钥匙
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("keyFuDian") && Input.GetMouseButtonDown(0) && ManagerUIScreen.btnPress ==1)
        {
            AssemblyCSharp.MyDebug.Log("============关闭辅电钥匙==============");
            ManagerGame.instance.objKeyFuDian.GetComponent<cakeslice.Outline>().enabled = false;

            //ManagerAni.instance.ani.SetBool("keyFuDian", true);
            ManagerGame.instance.objKeyFuDian.transform.rotation = new Quaternion(0, 101.5f,6.2f,0);
        }

        //控制台钥匙开关按钮
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.CompareTag("keyOnOff") && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("============选中控制台钥匙开关==============");
            ManagerGame.instance.objKeyDong.GetComponent<cakeslice.Outline>().enabled = false;
            
            ManagerAni.instance.ani.SetBool("keyDong", true);

        }

    }
}
