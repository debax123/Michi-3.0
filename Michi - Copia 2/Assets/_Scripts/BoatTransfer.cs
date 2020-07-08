using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatTransfer : MonoBehaviour
{
    public GameObject transfer;
    public GameObject boatPart;
    public GameObject boat;
    public bool isGO;
    public CharacterController charac;
    public Image fade;
    [SerializeField] private Transform player;
    [SerializeField] private Transform transferPoint;

    private void Start()
    {
        isGO = false;
    }

    void Update()
    {
        if(BoatPuzlleFinish.complete)
        {
            GameManager.level2 = false;
            GameManager.level3 = true;
            if (!isGO)
            {
                isGO = true;
                StartCoroutine(TransportRoutine());
            }
        }
    }
    private IEnumerator TransportRoutine()
    {
        yield return new WaitForSeconds(2f);
        charac.enabled = false;
        Color cor = fade.color;

        yield return new WaitForSeconds(1);

        while (cor.a < 1)
        {
            cor.a += Time.deltaTime;
            fade.color = cor;
            yield return null;
        }

        transfer.SetActive(true);
        boatPart.SetActive(false);
        boat.SetActive(true);
        player.transform.position = transferPoint.transform.position;
        Physics.SyncTransforms();

        yield return new WaitForSeconds(1);

        while (cor.a > 0)
        {
            cor.a -= Time.deltaTime;
            fade.color = cor;
            yield return null;
        }

        charac.enabled = true;

    }
}
