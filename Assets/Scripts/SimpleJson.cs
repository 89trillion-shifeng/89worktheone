using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;

/**
 * 该类使用simplejson解析json文件，数据供给其他类使用
 */
public class SimpleJson
{

    public static List<JSONNode> JsontoData()
    {
        List<JSONNode> jsonList = new List<JSONNode>();       //定义存放json数据的集合
        StringReader stringReader = new StringReader(Application.dataPath + "/Json/data.json");
        string strJSON = stringReader.ReadToEnd();
        //使用simplejson进行解析
        var jsonData = JSON.Parse(strJSON);
        for (int i = 0; i < jsonData["dailyProduct"].Count; i++)
        {
            jsonList.Add(jsonData["product"][i]);
            Debug.Log(jsonList);
        }

        return jsonList;
    }
  
}