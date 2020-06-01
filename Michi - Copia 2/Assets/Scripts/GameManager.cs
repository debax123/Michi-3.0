using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool crack;
    public static bool level1;
    public static bool level2;
    public static bool level3;

    public Transform player;
    public Transform teleporteTemplo;
    public Transform teleportePreVila;
    public Transform teleporteVila;
    public Transform teleporteCaverna;
    public Transform teleportePier;
    public Transform teleporteCemiterio;

    public static bool isPaused = false;

    public GameObject pauseMenuUI;

    public static int currentFish;
    public static int currentSouls;

    public Text fishText;
    public Text soulsText;

    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CursorBeginCorout());
        crack = false;
        level1 = true;
        level2 = false;
        level3 = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
        {
            if(crack)
            {
                crack = !crack;
            } else
            {
                crack = !crack;
            }
        }
        if (crack)
        {
            if(Input.GetKeyDown(KeyCode.F1))
            {
                AddFish(1);
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                AddSoul(1);
            }
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                player.transform.position = teleporteTemplo.transform.position;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                player.transform.position = teleportePreVila.transform.position;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                player.transform.position = teleporteVila.transform.position;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                player.transform.position = teleporteCaverna.transform.position;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                player.transform.position = teleportePier.transform.position;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                player.transform.position = teleporteCemiterio.transform.position;
            }
        }

    }

    public void AddFish(int fishToAdd)
    {
        currentFish += fishToAdd;
        fishText.text = ":" + currentFish;
    }
    public void AddSoul(int soulToAdd)
    {
        currentSouls += soulToAdd;
        soulsText.text = ":" + currentSouls;
    }

    public void Resume()
    {
        CameraController.rotateSpeed = 5;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        CameraController.rotateSpeed = 0;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public IEnumerator CursorBeginCorout()
    {
        CameraController.rotateSpeed = 0;
        yield return new WaitForSeconds(2);
        CameraController.rotateSpeed = 5;
        StopCoroutine(CursorBeginCorout());
    }

}
