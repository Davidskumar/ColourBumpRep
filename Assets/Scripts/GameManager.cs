using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Text currentLevelText,nextLevelText;
    private Image fill;
    private int level;
    private float startDistance,distance;
    private GameObject player,finish,hand;
    private TextMeshPro levelNo;
    // Start is called before the first frame update
    void Awake()
    {
        currentLevelText = GameObject.Find("CurrentLevelText").GetComponent<Text>();
        nextLevelText = GameObject.Find("NextLevelText").GetComponent<Text>();
        fill = GameObject.Find("Fill").GetComponent<Image>();
        player = GameObject.Find("Player");
        finish = GameObject.Find("Finish");
        hand = GameObject.Find("Hand");
        levelNo = GameObject.Find("LevelNo").GetComponent<TextMeshPro>();
    }
void Start()
    {
    level = PlayerPrefs.GetInt("Level",1);
    levelNo.text = "Level " +level;
    nextLevelText.text = level + 1 +" ";
    currentLevelText.text = level.ToString();

    startDistance = Vector3.Distance(player.transform.position,finish.transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, finish.transform.position);
        if(player.transform.position.z<finish.transform.position.z)
        {
            fill.fillAmount = 1 - (distance/startDistance);
        }
    }
    public void removeui()
    {
        hand.SetActive(false);
    }
}
