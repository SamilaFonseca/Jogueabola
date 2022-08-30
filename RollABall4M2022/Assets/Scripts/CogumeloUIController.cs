using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CogumeloUIController : MonoBehaviour
{
    // referencia para o objeto de texto da interface
    [SerializeField] private TMP_Text cogumeloText;

    private void OnEnable()
    {
        // Se inscreve no canal de cogumelo
        PlayerObserverManager.OncogumeloChanged += UpdatecogumeloText;
    }

    private void OnDisable()
    {
        // Retira a inscrição no canal de cogumelos
        PlayerObserverManager.OncogumeloChanged -= UpdatecogumeloText;
    }

    // funcao usada para tratar a notificacao do canal
    // de cogumelos
    private void UpdatecogumeloText(int newcogumeloValue)
    {
        // atualiza o valor dos cogumelos na interface
        cogumeloText.text = newcogumeloValue.ToString();
    }

}