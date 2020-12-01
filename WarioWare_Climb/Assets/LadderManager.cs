using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Management;

public class LadderManager : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.needToCheck)
        {
            GameManager.Instance.needToCheck = false;
            UpdateList();
        }
    }


    private void UpdateList()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            GameManager.Instance.positions.Add(gameObject.transform.GetChild(i).gameObject);
        }
    }
}
