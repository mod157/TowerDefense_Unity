using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Monster;
using PathCreation;
using PathCreation.Examples;

public class MonsterState : MonoBehaviour
{
    private TypeMonster typeMonster;

    private MonsterAnimationManager monsterAnimationManager;

    private MonsterHealthBar healthBarManager;

    private PathFollower pf;
    private bool isDeath = false;
    public float health;
    
    public bool isBoss = false;
    private GameObject gameUI;

    private void Start() {
        typeMonster = GetComponent<TypeMonster>();
        monsterAnimationManager = GetComponent<MonsterAnimationManager>();
        healthBarManager = GetComponentInChildren<MonsterHealthBar>();
        pf = GetComponent<PathFollower>();
        health = typeMonster.GetHP();
        healthBarManager.SetMaxHealth((int)health);
    } 

    public void TakeDamage(float damage){
        health -= damage;
        healthBarManager.SetHealth((int)health);
        if(health <= 0 && !isDeath){
            isDeath = true;
            Death();
        }

        if(isBoss && health <= typeMonster.GetHP() / 2){
            monsterAnimationManager.Skill();
        }
    }

    public void Death(){
        monsterAnimationManager.Death();
        gameObject.tag = "Death";
        GameManager.Instance.MonsterCoin(typeMonster.GetCoin());
        StartCoroutine(MonsterDeath());
    }


    IEnumerator MonsterDeath(){
        pf.speed = 0;
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
    }

    public void PathEndPoint(){
        gameObject.SetActive(false);
        GameManager.Instance.LifeBar(isBoss);
    }
}
