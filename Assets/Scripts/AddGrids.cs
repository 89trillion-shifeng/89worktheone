using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class AddGrids : MonoBehaviour
    {
        //获取Content的RectTransform
        [SerializeField] private RectTransform contentTransform;
       //定义一个路径常量，便于使用路径    private const string path = "Resources/Perfabs/";

       void Start()
       {
        InitCard();
       }

       //创建实例填充
        public void InitCard()
        {
            //从json中获取数据
            List<JSONNode> list = SimpleJson.JsontoData();
            foreach (JSONNode value in list)
            {
                switch (int.Parse(value["type"]))
                {
                    case 1:  //coins
                        Instantiate(Resources.Load("Resources/Perfabs/CoimCard"),contentTransform);
                        break;
                    case 2:  //diamonds
                        Instantiate(Resources.Load("Resources/Perfabs/DiamondCard"),contentTransform);
                        break;
                   /* case 3:  //coins
                        NoemalCard.SetNormal(value["subType"]);
                        Instantiate(Resources.Load("Resources/Perfabs/NormalCard"),contentTransform);
                        break;*/
                }
                
            }
            //补齐空位
            if (list.Count % 3 == 0)
                return;
            else
            {
                for (int i = 0; i < 3-list.Count%3; i++)
                {
                    Instantiate(Resources.Load("Resources/Perfabs/LockedCard"), contentTransform);
                }
            }
            
        }
        
    }
