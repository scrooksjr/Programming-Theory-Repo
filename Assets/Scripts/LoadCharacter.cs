using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    [SerializeField]
    public GameObject[] characterPrefabs;

    [SerializeField]
    public Transform spawnPoint;

    [SerializeField]
    public TMP_Text label;

    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        label.text = prefab.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
