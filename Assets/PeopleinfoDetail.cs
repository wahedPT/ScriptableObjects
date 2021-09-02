using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PeopleinfoDetail : MonoBehaviour
{
    public PeopleInfo pInfo;
    public Text nameText;
    public Text ageText;
    public Text emailText;
    // Start is called before the first frame update
    void Start()
    {

        nameText.text = pInfo.Name;
        ageText.text = pInfo.Age.ToString();
        emailText.text = pInfo.number.ToString()
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
