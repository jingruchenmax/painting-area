using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    [SerializeField]
    List<GameObject> stars;
    List<Animator> animators;
    void Start()
    {
        animators = new List<Animator>();
        foreach(GameObject ob in stars)
        {
            if (ob.GetComponent<Animator>() != null)
            {
                animators.Add(ob.GetComponent<Animator>());
            }
        }
        DefaultAnimationState();
    }

    public void DefaultAnimationState()
    {
        foreach (Animator anim in animators)
        {
            if (anim.GetBool("isGrow") == true)
            {
                anim.SetBool("isGrow", false);
            }
        }
        

    }

    public void PlayAnimation(int index)
    {
        if (index < animators.Count)
        {
            if (animators[index].GetBool("isGrow")==false)
            {
                animators[index].SetBool("isGrow",true);
            }
        }
    }
}
