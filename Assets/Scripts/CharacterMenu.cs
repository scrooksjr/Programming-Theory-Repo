using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CharacterMenu : MonoBehaviour
{

    [SerializeField]
    public GameObject[] characters;

    [SerializeField]
    public int selectedCharacter = 0;

    [SerializeField]
    public float speed = 20.0f;

    [SerializeField] // exposes private variables in the inspector
    public Material bodyColor;

    [SerializeField]
    private Material headColor;


    // Start is called before the first frame update
    void Start()
    {
        //bodyColor = characters[selectedCharacter].GetComponent<Material>();
        //headColor = characters[selectedCharacter].GetComponent<Material>();
        //SpawnCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        SelectCharacter();
    }

    void SelectCharacter()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Instantiate(characters[selectedCharacter]);
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(characters[selectedCharacter]);
        }
    }

    void RotateCharacter()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            characters[selectedCharacter].transform.Rotate(0, 1, 0);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            characters[selectedCharacter].transform.Rotate(0, -1, 0);
        }
    }

    void SpawnCharacter () // create new higher-level method.
    {
        for (int i = 0; i < characters.Length; i++)
        {
            
        }
    }

    public void NextCharacter()
    {
        characters[0].SetActive(false);
        selectedCharacter = (selectedCharacter +1)% characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[0].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void LoadCharacter()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}