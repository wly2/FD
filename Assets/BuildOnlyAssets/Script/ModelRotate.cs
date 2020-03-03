using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

#region Author & Version
/* ========================================================================  
*Author：WLY 
* File name：
* Version：V1.0.1
* Company: 
* 创建：    
* Date : 2019.0606    14:12
* 功能描述：     ...............模型展示场景的模型查看效果................    
* 版本：     主.次.月日.时分  修改者姓名  修改内容    
*            ............       ....      .......        
* ========================================================================
*/
#endregion

public class ModelRotate : MonoBehaviour
{

    //public GameObject Go_Model;
    Vector2 first = Vector2.zero;    //记录鼠标点击的初始位置
    Vector2 second = Vector2.zero;   //记录鼠标移动时的位置
    bool directorToLeft = false;
    bool directorToRight = false;
    bool dragging = false;   //标记是否鼠标在滑动
    float speed = 0;
    public static int y = 0;
    float moveSpeed = 3f;
    float isRotate = 0f;
    Ray ray;
    RaycastHit hit;

    Animator ani;


    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        modelRotate();
    }


    /// <summary>
    /// 模型查看效果
    /// </summary>
    public void modelRotate()
    {
        isRotate = y;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            //================================key1====================================//
            if (hit.collider.gameObject.tag == "key1")
            {
                Debug.Log("选中钥匙");
                ani.SetBool("isKey1", true);
                ManagerGame.instance.txtTip.text = ConfigPath.STEP3;
            }
            //================================Key2===========================//
            if (hit.collider.gameObject.tag == "key2")
            {
                Debug.Log("选中钥匙2");
                ani.SetBool("isKey2", true);
               // ManagerGame.instance.txtTip.text = ConfigPath.STEP3;
            }
        }
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            //================================打开计算机====================================//
            if (hit.collider.gameObject.tag == "computer")
            {
                Debug.Log("打开电脑");
                ManagerGame.instance.txtTip.text = ConfigPath.STEP4;
            }
        }


    }

    public void start() { }

    public void finish()
    {
        Debug.Log("动画结束");
       
    }
}
