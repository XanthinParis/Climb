using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Management
{
    public class GameManager : Singleton<GameManager>
    {
        [Header("Tableau de Positions")]
        public GameObject ladderParent;
        public List<GameObject> positions = new List<GameObject>();
        public bool needToCheck = false;

        [Header("Variables")]
        public int numberOfLadder = 0;
        public int numberOfLadderNeeded = 0;

        [Header("PlayerReference")]
        public GameObject player;
        public int playerPosition;

        [Header("InputBools")]
        [SerializeField] private bool canLeft = false;
        [SerializeField] private bool canRight = true;

        void Awake()
        {
            CreateSingleton(true);
        }

        private void Update()
        {
            player.transform.position = positions[playerPosition].transform.position;

            PlayerInput();
        }

        void PlayerInput()
        {
            if (Input.GetButtonDown("Fire1") && canLeft)
            {
                canRight = true;
                playerPosition+=1;
                canLeft = false;
                return; 

            }
            else if (Input.GetButtonDown("Fire2") && canRight)
            {
                canLeft = true;
                canRight = false;
                playerPosition++;
                return;
            }
        }
    }
}

