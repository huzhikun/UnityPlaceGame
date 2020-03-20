using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceGames : MonoBehaviour
{
    /// <summary>
    /// 角色属性
    /// </summary>
    [System.Serializable]
    public class BaseAttribute
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
        public float Exp, CriticalRate, CriticalDamage;

        /// <summary>
        /// 每秒血量恢复，每秒魔量恢复。
        /// </summary>
        public float HPRecoverPerSecond, MPRecoverPerSecond;
    }
}