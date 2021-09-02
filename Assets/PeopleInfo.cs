using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[CreateAssetMenu(fileName ="Card",menuName ="CardInfo",order =20)]
[CreateAssetMenu(fileName = "Player Data", menuName = "PlayerData", order = 50)]
public class PeopleInfo : ScriptableObject
{
  

   
        public enum LEVEL { Beginner, Intermediate, Advanced }
        [SerializeField]
        private string playerName;
        [SerializeField]
        private int age;
        [SerializeField]
        private int playerNumber;

        public string Name { get { return playerName; } }
        public int Age { get { return age; } }
        public int number { get { return playerNumber; } }
    


    //[SerializeField]
    //private string Name;
    //[SerializeField]
    //private int Age;
    //[SerializeField]
    //private string Email;

}
