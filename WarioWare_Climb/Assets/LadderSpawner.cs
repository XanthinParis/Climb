using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Management;

public class LadderSpawner : MonoBehaviour
{
    public GameObject ladderPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.numberOfLadder < GameManager.Instance.numberOfLadderNeeded)
        {
            GameObject instanciateLadder =  Instantiate(ladderPrefab, transform.position, Quaternion.identity);
            instanciateLadder.transform.parent = GameManager.Instance.ladderParent.transform;
            GameManager.Instance.numberOfLadder+=1;
            Debug.Log("if");
        }
        else
        {
            GameManager.Instance.needToCheck = true;
            Debug.Log("else");
        }

    }
}
