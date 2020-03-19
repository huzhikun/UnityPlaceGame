using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LCYFK : MonoBehaviour
{
    public Text playerLvText, lingCaoYuanLvText, tiShiText, playerLvwb,lingCaoYuanLvwb;

    int lingCao=0, jingYan=0, playerLv = 1, lingCaoYuanLv = 1;


    public void OnApplicationQuit()
    {
        Save_f();
    }

    // Start is called before the first frame update
    void Start()
    {
        Load_f();
        InvokeRepeating("Time_f", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit() {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    void Time_f() {
        if (lingCaoYuanLv > 1)
        {
            lingCao = lingCao + lingCaoYuanLv ;
        }
        else {
            lingCao++;
        }

        playerLvText.text = "(" + jingYan + "/" + playerLv * 100 + ")";
/*        playerLvwb.text = playerLv.ToString();

        lingCaoYuanLvwb.text = lingCaoYuanLv.ToString();
*/
        lingCaoYuanLvText.text = "(" + lingCao + "/" + lingCaoYuanLv * 100 + ")";

        tiShiText.text = "灵草+1！";
 
    }

    public void Button_jingYanLvUp() {
        if (lingCao > 0) {
            lingCao--;
            if (Random.Range(0, 100) < 10)
            {
                jingYan += 10;
                tiShiText.text = "采到中等灵草，经验+10！";
            }
            else if (Random.Range(0, 100) < 5)
            {
                jingYan += 50;
                tiShiText.text = "居然是上等灵草，经验+30！";
            }
            else if (Random.Range(0, 100) < 2)
            {
                jingYan += 100;
                tiShiText.text = "天呐！居然采到变异灵草，经验+100！";
            }
            else{
                jingYan++;
            }
        }
        else
        {
            tiShiText.text = "灵草采完了！";
        }
        playerLvText.text = "(" + jingYan + "/" + playerLv * 100 + ")";
    }

    public void Button_lingCaoYuanLvUp() {
        if (lingCao > lingCaoYuanLv * 100)
        {
            lingCao -= lingCaoYuanLv * 100;
            lingCaoYuanLv++;
            tiShiText.text = "恭喜你，灵草园等级提升1！";
            lingCaoYuanLvwb.text = lingCaoYuanLv.ToString();
        }
        else {
            tiShiText.text = "灵草不够拉！";
        }
    }

    public void Button_playerLvUp() {
        if (jingYan > playerLv * 100)
        {
            jingYan -= playerLv * 100;
            playerLv++;
            tiShiText.text = "恭喜你等级提升1！";
            playerLvwb.text = playerLv.ToString();
        }
        else {
            tiShiText.text = "经验不够拉！";
        }
    }

    void Save_f() {
        PlayerPrefs.SetInt("lingCao", lingCao);
        PlayerPrefs.SetInt("jingYan",jingYan);
        PlayerPrefs.SetInt("playerLv", playerLv);
        PlayerPrefs.SetInt("lingCaoYuanLv", lingCaoYuanLv);
    }

    void Load_f() {
        lingCao = PlayerPrefs.GetInt("lingCao");
        jingYan = PlayerPrefs.GetInt("jingYan");
        playerLv = PlayerPrefs.GetInt("playerLv");
        lingCaoYuanLv = PlayerPrefs.GetInt("lingCaoYuanLv");

        playerLvText.text = "("+ jingYan + "/"+ playerLv * 100+")";
        lingCaoYuanLvText.text = "(" + lingCao + "/" + lingCaoYuanLv * 100 + ")";
        playerLvwb.text = PlayerPrefs.GetInt("playerLv").ToString();
        lingCaoYuanLvwb.text = PlayerPrefs.GetInt("lingCaoYuanLv").ToString();

    }
}
