﻿using System.Collections;
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
* 功能描述：     ...............协程管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ManagerIEnumerator : MonoSingleton<ManagerIEnumerator>
{

    public float IEtime;//协程等待时间

    /// <summary>
    /// 打开辅电时等待时间
    /// </summary>
    /// <param name="waitTime"></param>
    /// <returns></returns>
    public  IEnumerator IEfudian(float waitTime)
    {
        IEtime = waitTime;
        yield return new WaitForSeconds(IEtime);
       

      
    }

}