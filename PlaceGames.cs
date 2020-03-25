using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceGames : MonoBehaviour
{
        public Text TextPrint;
    /// <summary>
    /// �����ɫ���ԣ���ʼ����ɫ��Χ
    /// </summary>
    class RoleAttribute
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
        public float Exp;//, CriticalRate, CriticalDamage;

        /*
                /// <summary>
                /// ÿ��Ѫ���ָ���ÿ��ħ���ָ���
                /// </summary>
                public float HPRecoverPerSecond, MPRecoverPerSecond;
            }
        */

        /// <summary>
        /// �����������ֵ
        /// </summary>
        public int Luckys;

        /// <summary>
        /// ��������Ը�
        /// </summary>
        // public string Character;


        /// <summary>
        /// ��ʼ����ɫ��Χ
        /// </summary>
        public void BasePlayers()
        {

            //�����ɫ��ʼ�ȼ������������������ݣ�����
            LV = 1;
            Strong = Random.Range(1, 11);
            Intelligence = Random.Range(1, 11);
            Agility = Random.Range(1, 11);
            Luckys = Random.Range(1, 11);

        }
        /// <summary>
        /// ������ɫ����ʼ���ԣ��Լ���������
        /// </summary>
        public void PlayerUpLv()
        {
            Strong = Strong + (1 + Strong / 10) * (LV - 1);
            //�������1��8 ��2��8+1.8����������+��1+��������/10��*LV
            Intelligence = Intelligence + (1 + Intelligence / 10) * (LV - 1);
            Agility = Agility + (1 + Agility / 10) * (LV - 1);

            //�����ɫ��ʼ������ħ��
            HP = Strong * 10;
            MP = Intelligence * 3;

            //�����ɫ��ʼ�����ͷ���
            float UpAttack = Strong * 5;
            float UpDefend = Strong * 2;

            //���������������
            Exp = LV * 100;

            //��ʼ����Ը�
            //PlayerOne.Character = "a";

        }

        /// <summary>
        /// �����û�����
        /// </summary>
        public void SavePlayerData()
        {
            PlayerPrefs.SetIn("Strong",strong);
            PlayerPrefs.SetIn("Intelligence", Intelligence);
            PlayerPrefs.SetIn("Agility", Agility);
            PlayerPrefs.SetIn("Luckys", Luckys);
            PlayerPrefs.SetIn("LV", LV);
        }

        /// <summary>
        /// ��ȡ�û�����
        /// </summary>
        public void LoadPlayerData()
        {
            LV = PlayerPrefs.Get("LV");
            Strong = PlayerPrefs.Get("Strong");
            Intelligence = PlayerPrefs.Get("Intelligence");
            Agility = PlayerPrefs.Get("Agility");
            Luckys = PlayerPrefs.Get("Luckys");
        }

        public void OnApplicationQuit()
        {
            SavePlayerData();
        }
    }




    void Start()
    {
        RoleAttribute PlayerOne = new RoleAttribute();
        PlayerOne.BasePlayers();
        PlayerOne.OnApplicationQuit();
        PlayerOne.LoadPlayerData();
        PlayerOne.PlayerUpLv();
        TextPrint.text = "�ȼ��ǣ�" + PlayerOne.LV + "�������ǣ�" + PlayerOne.Strong + "�������ǣ�"
                        + PlayerOne.Intelligence + "�������ǣ�" + PlayerOne.Agility+ "�������ǣ�" + PlayerOne.Luckys;


    }
}