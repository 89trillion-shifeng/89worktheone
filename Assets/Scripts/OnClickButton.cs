using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickButton : MonoBehaviour
{
    [SerializeField] private GameObject InView;

    [SerializeField] private GameObject OutView;

    public void TurnView()
    {
        InView.SetActive(true);
        OutView.SetActive(false);
    }
}
