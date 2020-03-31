using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.0605    14:12
* 功能描述：     ...............开始场景管理................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion
public class ManagerStart : MonoBehaviour
{

    public void LoadSceneLoading()
    {
         SceneManager.LoadScene(Assets.Scripts.PathScene.SCENE_LOADING);
    }

    public void LoadSceneMeetingLoading()
    {
        SceneManager.LoadScene(Assets.Scripts.PathScene.SCENE_LOADING_MEETING);
    }
}

