using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

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

public class CinemachineController : MonoSingleton<CinemachineController>
{
    public List<CinemachineVirtualCamera> CVcamera = new List<CinemachineVirtualCamera>();

     
    private void Awake()
    {
        //for (int i = 0; i < CVcamera.Count; i++)
        //{
        //    CVcamera[i] = GetComponent<CinemachineVirtualCamera>();
        //}
    }


    private void Start()
    {
        //CVcamera[2].gameObject.SetActive(true);
        //print(CVcamera[2]);
    }



}