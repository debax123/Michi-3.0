using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerCutscene : MonoBehaviour
{
    public Image fade;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            //if(Input.GetKeyDown(KeyCode.F))
            //{
                StartCoroutine(Fim());
            //}
        }
        
    }

    IEnumerator Fim()
    {
        yield return new WaitForSeconds(0.2f);
        Color cor = fade.color;

        yield return new WaitForSeconds(1);

        while (cor.a < 1)
        {
            cor.a += Time.deltaTime;
            fade.color = cor;
            yield return null;
        }

        SceneManager.LoadScene("Cutscene Final");
    }
}
