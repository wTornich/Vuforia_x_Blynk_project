using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class request : MonoBehaviour
{
    public TextMeshProUGUI LED1;
    public TextMeshProUGUI LED2;
    public TextMeshProUGUI GRAPH;
    [SerializeField] Image image_graph;

    void Start()
    {
        StartCoroutine(GetInformations());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator GetInformations()
    {

        string led1 = "https://blynk.cloud/external/api/get?token=--------------------------------&dataStreamId=1";
        string led2 = "https://blynk.cloud/external/api/get?token=--------------------------------&dataStreamId=2";
        string graph = "https://blynk.cloud/external/api/get?token=------------------------------&dataStreamId=3";


        UnityWebRequest wwwled1 = UnityWebRequest.Get(led1);
        UnityWebRequest wwwled2 = UnityWebRequest.Get(led2);
        UnityWebRequest wwwgraph = UnityWebRequest.Get(graph);

        yield return wwwled1.SendWebRequest();
        yield return wwwled2.SendWebRequest();
        yield return wwwgraph.SendWebRequest();

        if (wwwled1.isNetworkError || wwwled1.isHttpError)
        {
            LED1.text = "Error";
        }
        else
        {
            int valor = int.Parse(wwwled1.downloadHandler.text);
            if (valor == 1)
            {
                LED1.color = Color.green;
                LED1.text = "ON";
            } else if (valor == 0)
            {
                LED1.color = Color.red;
                LED1.text = "OFF";
            }
            
        }

        if (wwwled2.isNetworkError || wwwled2.isHttpError)
        {
            LED2.text = "Error";
        }
        else
        {
            int valor = int.Parse(wwwled2.downloadHandler.text);
            if (valor == 1)
            {
                LED2.color = Color.green;
                LED2.text = "ON";
            }
            else if (valor == 0)
            {
                LED2.color = Color.red;
                LED2.text = "OFF";
            }

        }

        if (wwwgraph.isNetworkError || wwwgraph.isHttpError)
        {
            GRAPH.text = "Error";
        }
        else
        {
            string valor = wwwgraph.downloadHandler.text;
            GRAPH.text = valor;
            image_graph.fillAmount = Mathf.InverseLerp(0, 100, int.Parse(valor));

        }

        yield return new WaitForSeconds(1);
        StartCoroutine(GetInformations());
    }




}
