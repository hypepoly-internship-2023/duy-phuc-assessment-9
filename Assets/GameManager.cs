using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] messages;
    [SerializeField] private GameObject buttonPrefab, content;
    [SerializeField] private int numberButton;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numberButton; i++)
        {
            int index = new();
            index = i + 1;
            GameObject newButton = Instantiate(buttonPrefab, content.transform);
            newButton.transform.GetChild(0).GetComponent<TMP_Text>().text = (i + 1).ToString();
            string rndText = messages[Random.Range(0, messages.Length - 1)];
            newButton.transform.GetChild(1).GetComponent<TMP_Text>().text = rndText;
            newButton.gameObject.GetComponent<Button>().onClick.AddListener(delegate { Print(index, rndText); });
        }
    }

    void Print(int index, string message)
    {
        if(index%3==0)
        {
            Debug.Log(message);
        } else
        {
            Debug.Log(index);
        }
    }
}
