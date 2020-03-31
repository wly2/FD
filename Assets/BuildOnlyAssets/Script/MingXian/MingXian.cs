using AssemblyCSharp;
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
* 功能描述：     ..............隧道场景逻辑................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class MingXian : MonoSingleton<MingXian>
{
    [HideInInspector]public bool isMingXian = false;

    // Start is called before the first frame update
    void Start()
    {
        isMingXian = true;
        MyDebug.Log("当前场景是：" + isMingXian);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}