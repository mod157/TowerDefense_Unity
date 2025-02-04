﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation.Examples;

public class MonsterAnimationManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator anim;

    public string skillName;

    public float skillHoldingTime;

    public float skillWaitTime;
    public float skillCooldown;

    private bool isColldown = false;

    private PathFollower pf;

    private float oriSpeed;

    void Start()
    {
        if(anim == null){
            anim = GetComponent<Animator>();
        }
        pf = GetComponent<PathFollower>();
        oriSpeed = pf.speed;
        Walk();

       
    }

    public void Walk(){
        pf.SetSpeed(oriSpeed);
        anim.SetBool("isWalking",true);
    }

    public void Run(){

    }

    public void Death(){
        anim.SetBool("isWalking",false);
        anim.SetBool("isDead", true);
    }

    //Skill이 발생 시 데이터화를 받아서 여기서 정리해서 발생하는 것으로
    public void Skill(){
        if(!isColldown){
            Debug.Log("SKill");
            isColldown = true;
            anim.SetTrigger("isSkill");
            StartCoroutine(SetupSkill());
        }
    }
    
    IEnumerator SetupSkill(){
    
        anim.SetBool(skillName, true);
        pf.SetSpeed(pf.speed * 1.5f);
        yield return new WaitForSeconds(skillHoldingTime);
        anim.SetBool(skillName , false);
        pf.SetSpeed(0f);
        yield return new WaitForSeconds(skillWaitTime);
        Walk();
        yield return new WaitForSeconds(skillCooldown);
        isColldown = false;

        yield return null;
    }
}
