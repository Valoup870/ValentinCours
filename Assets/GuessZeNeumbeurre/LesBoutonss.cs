using TMPro;
using UnityEngine;

public class LesBoutonss : MonoBehaviour
{
    
    public TMP_Text messageTEXT;
    public TMP_InputField inputNumber;

    private int randomNumber;

    private void Start()
    {
        resetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(inputNumber.text) == true)
        {
            messageTEXT.text = "Plise, Guesse Zeu Neumbeurre !!!!!!!!";
            inputNumber.text = "";
            return;
        }

        if (int.TryParse(inputNumber.text, out int playerNumber))
        {
            if(playerNumber == randomNumber) 
            {
                messageTEXT.text = "VICTORIA";
            }
            else if(playerNumber > randomNumber)
            {
             messageTEXT.text = "Un pé mouin...";
            }
            else if (playerNumber < randomNumber)
            {
                messageTEXT.text = "Un pé plousse...";
            }
        }
        else
        {
            messageTEXT.text = "Plise, POUTE ZEU CORRECTE NEUMBEURRE !!!";
        }
        inputNumber.text = "";
    }
    public void resetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
        messageTEXT.text = "Guesse Zeu Neumbeurre...";
    }

}
