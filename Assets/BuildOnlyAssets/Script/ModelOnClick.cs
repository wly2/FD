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

public class ModelOnClick : MonoBehaviour
{
    [HideInInspector] public Ray ray;
    [HideInInspector] public RaycastHit hitInfo;

    private void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject.tag == "jiaojia" && Input.GetMouseButtonDown(0))
        {
            AssemblyCSharp.MyDebug.Log("**************************选中脚架***********************");
            ControlGame.instance.goBridgeFoot.GetComponent<cakeslice.Outline>().enabled = false;
            //播放动画....
            ControlAni.instance.ani.SetBool("installFoot", true);

        }
        }



}
    