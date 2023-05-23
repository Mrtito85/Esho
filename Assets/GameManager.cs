using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public GameObject playpanal;
    public GameObject Setting;
    public GameObject Credits;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SettingBtnClicked()
    {
        playpanal.SetActive(false);
        Setting.SetActive(true);
    }
    public void BackSettingBtnClicked()
    {
        playpanal.SetActive(true);
        Setting.SetActive(false);
    }

    public void CreditsBtnClicked()
    {
        playpanal.SetActive(false);
        Credits.SetActive(true);
    }
    public void BackCreditsBtnClicked()
    {
        playpanal.SetActive(true);
        Credits.SetActive(false);
    }
}
