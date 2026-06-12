using UnityEngine;

public class CardValues : MonoBehaviour
{
    public int cardValue;
    public int CardValueChange;
    public Animator animator;

    public void CardValuesChange(int CardValueChange, int cardValue)
    {
        cardValue += CardValueChange;

    }

    public void doaflip()
    {
        animator.Play("doaflip");
    }

}
