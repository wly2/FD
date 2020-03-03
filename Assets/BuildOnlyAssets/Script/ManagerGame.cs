using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class ManagerGame : MonoSingleton<ManagerGame>
{
    public Text txtTip;
    public GameObject Player;//玩家位置
    [SerializeField] GameObject imgModeType;//学习模式
    [SerializeField] GameObject imgGongKuang;//选择工况
    [SerializeField] GameObject imgTypeTrain;//选择车型
    [SerializeField] GameObject imgBridge;//安装桥梁选项框

/// <summary>
/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
void Start()
{
    txtTip.text = Assets.Scripts.BridgeStep.TAKE2;
}
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        // GameStart();
        //GameStep();
    }


    public void GameStart()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            txtTip.text = ConfigPath.STEP1;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {

        }

    }

    /// <summary>
    /// 操作室视角
    /// </summary>
    public void PlayerPos1()
    {
        Player.transform.position = new Vector3(7.694f, 4.651f, -51.482f);
    }

    /// <summary>
    /// 实验室视角
    /// </summary>
    public void PlayerPos2()
    {
        Player.transform.position = new Vector3(6.24004f, 839173f, -37.812f);
    }

    /// <summary>
    /// 学习模式
    /// </summary>
    public void ModeStudy()
    {
        imgModeType.SetActive(false);
    }

    /// <summary>
    /// 选择车型
    /// </summary>
    public void ChoBridge()
    {
        imgTypeTrain.SetActive(true);
    }

    /// <summary>
    /// 关闭选择工况选项框
    /// </summary>
    public void CloCho()
    {
        imgGongKuang.SetActive(false);
    }


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider something)
    {
        print("发生碰撞");
        if (something.tag == "bridge")
        {
            print("发生碰撞");

        }

    }

}
