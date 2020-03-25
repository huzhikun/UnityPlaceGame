using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceGames : MonoBehaviour
{
        public Text TextPrint;
    /// <summary>
    /// 定义角色属性，初始化角色三围
    /// </summary>
    class RoleAttribute
    {
        //等级
        public int LV;

        /// <summary>
        /// 血量，魔法
        /// </summary>
        public float HP, MP;

        /// <summary>
        /// 定义攻击，防御，力量，智力，敏捷
        /// </summary>
        public float Attack, Defend, Strong, Intelligence, Agility;

        /// <summary>
        /// 定义经验，暴击概率，暴击百分比
        /// </summary>
        public float Exp;//, CriticalRate, CriticalDamage;

        /*
                /// <summary>
                /// 每秒血量恢复，每秒魔量恢复。
                /// </summary>
                public float HPRecoverPerSecond, MPRecoverPerSecond;
            }
        */

        /// <summary>
        /// 玩家隐藏幸运值
        /// </summary>
        public int Luckys;

        /// <summary>
        /// 玩家隐藏性格
        /// </summary>
        // public string Character;


        /// <summary>
        /// 初始化角色三围
        /// </summary>
        public void BasePlayers()
        {

            //定义角色初始等级，力量，智力，敏捷，幸运
            LV = 1;
            Strong = Random.Range(1, 11);
            Intelligence = Random.Range(1, 11);
            Agility = Random.Range(1, 11);
            Luckys = Random.Range(1, 11);

        }
        /// <summary>
        /// 创建角色，初始属性，以及升级属性
        /// </summary>
        public void PlayerUpLv()
        {
            Strong = Strong + (1 + Strong / 10) * (LV - 1);
            //如果力量1是8 ，2是8+1.8，基础属性+（1+基础属性/10）*LV
            Intelligence = Intelligence + (1 + Intelligence / 10) * (LV - 1);
            Agility = Agility + (1 + Agility / 10) * (LV - 1);

            //定义角色初始生命和魔法
            HP = Strong * 10;
            MP = Intelligence * 3;

            //定义角色初始攻击和防御
            float UpAttack = Strong * 5;
            float UpDefend = Strong * 2;

            //定义玩家升级经验
            Exp = LV * 100;

            //初始玩家性格
            //PlayerOne.Character = "a";

        }
    }


/*
    /// <summary>
    /// 创建角色，初始属性，以及升级属性
    /// </summary>
    public float PlayerUpLv()
    {
        float UpStrong = Strong+(1+Strong/10)*(LV-1);
        //如果力量1是8 ，2是8+1.8，基础属性+（1+基础属性/10）*LV
        float UpIntelligence = Intelligence + (1 + Intelligence / 10) * (LV - 1);
        float UpAgility = Agility + (1 + Agility / 10) * (LV - 1);
        int UpLv = LV;

        //定义角色初始生命和魔法
        float UpHP = UpStrong * 10;
        float UpMP = UpIntelligence * 3;

        //定义角色初始攻击和防御
        float UpAttack = UpStrong * 5;
        float UpDefend = UpStrong * 2;

        //定义玩家升级经验
        int UpExp = UpLv * 100;

        //初始玩家性格
        //PlayerOne.Character = "a";

        TextPrint.text = "等级是：" +UpLv+"，力量是："+UpStrong;

        return UpStrong;

    }

*/

    void Start()
    {
        RoleAttribute PlayerOne = new RoleAttribute();
        PlayerOne.BasePlayers();
        PlayerOne.PlayerUpLv();
        TextPrint.text = "等级是：" + PlayerOne.LV + "，力量是：" + PlayerOne.Strong + "，智力是：" + PlayerOne.Intelligence + "，敏捷是：" + PlayerOne.Agility;


    }
}