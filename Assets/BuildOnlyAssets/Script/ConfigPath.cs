
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

        public const string STEP3 = "选中高亮部分，连接阀体";
        public const string STEP4 = "选中测压模块，连接电子扫描阀";
        public const string STEP5 = "选中高亮部分，测压模块连接电子扫描阀";
        public const string STEP6 = "选中高亮部分，连接电脑";
        public const string STEP7 = "扭动控制台加电钥匙";
        public const string STEP8 = "扭动控制计算机按钮";
        public const string STEP9 = "点击电脑显示屏ShuCtl软件";
        public const string STEP10 = "扭动控制箱辅电允许按钮";
        public const string STEP11 = "点击电脑显示屏开辅电按钮";

        public const string STEP12 = "一分钟后，点击电脑显示屏合闸按钮";
        public const string STEP13 = "一分钟后，点击电脑显示屏开车按钮";

        public const string STEP14 = "将电压逐渐降至0V，等转速降到15转以下，按软件中停车按钮";
    }

    public class BridgeGameStepTip
    {

        public const string TIP1 = "输入电压，加压幅度为0.5V";
        public const string TIPFUDIAN = "正在开辅电，请等待十秒钟!";
        public const string TIPFUDIAN_1 = "开辅电完毕!";

        public const string TIPHEZHA = "正在合闸，请等待十秒钟!";
        public const string TIPHEZHA_1 = "合闸完毕!";

        public const string TIPKAICHE = "正在开车，请等待5秒钟!";
        public const string TIPKAICHE_1 = "已经开车，可以加风速或转速!";

    }

}