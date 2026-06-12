using Unity.VisualScripting;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    public GameObject Manager;
    public int[] CardValues;
    public int[] DealValues;
    public int dealerScore;
    public int BustChance;
    public bool stand = false;
    public void DealersGo()
    {
        if (stand == true)
        {
            CardSpawner Cards = Manager.GetComponent<CardSpawner>();
            Cards.Hit();
        }
    }
}
