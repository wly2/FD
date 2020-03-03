using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2079.5.31  13:50
* 功能描述：     .................加载实验场景..............    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ControlLoading : MonoSingleton<ControlLoading>
{
    public Text txtProgess;
    public Image imgPregress;

    void Start()
    {
        loadScene();
    }

    void Update()
    {
        ManagerScene.instance.asyncLoading();
    }

    public void loadScene()
    {
        //列车气动力场景
        //if (ManagerScene.SceneType == ManagerScene.ScenesType.SCENEFD)
        //{
        StartCoroutine(ManagerScene.instance.ILoadingScene(Assets.Scripts.PathScene.SCENE_GAME));
        //StartCoroutine(ManagerScene.instance.ILoadingScene(Assets.Scripts.PathScene.SCENE_LOADING));
        //}
    }
}
