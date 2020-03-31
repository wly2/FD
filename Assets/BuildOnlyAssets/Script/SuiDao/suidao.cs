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
* 功能描述：     ...............场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class suidao : MonoSingleton<suidao>
{
    [HideInInspector] public bool isSuidao = false;
    public List<GameObject> camSuidao = new List<GameObject>();
    public GameObject goSuidao;

    // Start is called before the first frame update
    void Start()
    {
        isSuidao = true;
        MyDebug.Log("当前场景是：" + isSuidao);
    }

    // Update is called once per frame
    void Update()
    {

    }
}