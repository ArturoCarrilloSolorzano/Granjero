using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementLeft : MonoBehaviour
{
    public Button leftButton;
    public GameObject player;
    public float speed = 10.00f;
    // Start is called before the first frame update
    void Start()
    {
        Button left = leftButton.GetComponent<Button>();
        left.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        //Instantiate(projectilePrefab, player.transform.position, projectilePrefab.transform.rotation);
        player.transform.Translate(Vector3.right * -20f * Time.deltaTime * speed);
    }

}
