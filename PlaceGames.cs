using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceGames : MonoBehaviour
{
    /// <summary>
    /// ��ɫ����
    /// </summary>
    [System.Serializable]
    public class BaseAttribute
    {
        //�ȼ�
        public int LV;

        /// <summary>
        /// Ѫ����ħ��
        /// </summary>
        public float HP, MP;

        /// <summary>
        /// ���幥��������������������������
        /// </summary>
        public float Attack, Defend, Strong, Intelligence, Agility;

        /// <summary>
        /// ���徭�飬�������ʣ������ٷֱ�
        /// </summary>
        public float Exp, CriticalRate, CriticalDamage;

        /// <summary>
        /// ÿ��Ѫ���ָ���ÿ��ħ���ָ���
        /// </summary>
        public float HPRecoverPerSecond, MPRecoverPerSecond;
    }
}