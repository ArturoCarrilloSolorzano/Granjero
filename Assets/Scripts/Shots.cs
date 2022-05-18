using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shots : MonoBehaviour
{
    public Button shotButton;
    public GameObject projectilePrefab;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = shotButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Instantiate(projectilePrefab, player.transform.position, projectilePrefab.transform.rotation);
    }
}
