using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;

public class NoemalCard : MonoBehaviour
{
    [SerializeField] private GameObject ImageQuli;
    [SerializeField] private Image ImageObject;
    [SerializeField] private GameObject TextVikiing;
    [SerializeField] private Button ButtonBuy;
    [SerializeField] private GameObject buttonBuyGameObject;
    [SerializeField] private GameObject ImageCoin;
    [SerializeField] private GameObject TextPrice;
    //初始化卡片所在文件夹
    private const string cardPath = "Resources/Sprites/cards/";

    public   void SetNormal(JSONNode value)
    {    //对普通卡片的不同自类型进行修改
        switch (int.Parse(value["subType"]))
        {
            //卡片自类型为7
            case 7:
                ImageObject.sprite = Resources.Load<Sprite>(cardPath + "7");
                break;
            //卡片自类型为13
            case 13:
                ImageObject.sprite = Resources.Load<Sprite>(cardPath + "13");
                break;
            //卡片自类型为18
            case 18:
                ImageObject.sprite = Resources.Load<Sprite>(cardPath + "18");
                break;
            //卡片自类型为20
            case 20:
                ImageObject.sprite = Resources.Load<Sprite>(cardPath + "20");
                break;

        }
    }


}