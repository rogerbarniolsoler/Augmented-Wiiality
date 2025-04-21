using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public void Up()
    {
        animator.SetTrigger("Up");
    }

    public void Down()
    {
        animator.SetTrigger("Down");
    }
}
