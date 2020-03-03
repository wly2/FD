
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class ConfigPath
    {
        public const string STEP1 = "点击操作箱按钮切换到视角";
        public const string STEP2 = "将操作箱上的控制台加电开关旋转至打开位置";
        public const string STEP3 = "按“控制计算机”开关启动控制计算机";
        public const string STEP4 = "启动控制系统软件ShuCtl软件";
        public const string STEP5 = "将操作箱上的铺电开关旋转至打开位置";
    }

    public class PathScene
    {
        public const string SCENE_GAME = "SCENE_GAME";//实验场景
        public const string SCENE_LOADING = "SCENE_LOADING";//加载场景
    }

    /// <summary>
    /// 
    /// 搭建桥梁步骤
    /// </summary>
    public class BridgeStep
    {
        public const string TAKE2 = "安装脚架";
        public const string TAKE3 = "安装皮带";
        public const string TAKE4 = "安装桥梁";
        public const string TAKE5 = "安装铆钉";
        public const string TAKE6 = "安装列车";
    }
}
