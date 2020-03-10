
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
        public const string STEP1 = "选择脚架，将脚架挪到正确位置";
        public const string STEP2 = "选择皮带，将皮带挪到脚架上";
        public const string STEP3 = "选择桥梁，放置桥梁";
        public const string STEP4 = "选择滑块，拖动滑块至正确位置";
        public const string STEP5 = "选择列车车型，将列车放置桥梁上";

    }

    public class CeDianStep
    {
        public const string STEP1 = "选择皮托管，连接到列车正确的测点上";

    }

    public class FaTiStep
    {
        public const string STEP1 = "点击查看阀体";
        public const string STEP2 = "点击查看测压模块";
    }

    public class BriLabAbout

    {
        public const string YUANLI = "";
        public const string SHIYANMUDI = "";
    }

    public class BridgeGameStep
    {
        public const string STEP1 = "选择车型";
        public const string STEP2 = "选中桥梁脚架，移动到正确位置";
    }
}
