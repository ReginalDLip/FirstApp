using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerCharacter : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public string triggerName;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetTriggerNow(){
        _animator.SetTrigger(triggerName);

    }

    

}
