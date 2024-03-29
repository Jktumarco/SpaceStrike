﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy : MonoBehaviour
{
    [Header("Set in Inspector: Enemy")]
    public float speed = 15f;
    public float fireRate = 0.3f;
    public float health = 10;
    public int score = 100;
    protected BoundsCheck bndCheck;
   

    void Awake()
    {
        
        bndCheck = GetComponent<BoundsCheck>();
       
    }
    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        if ( bndCheck != null && bndCheck.offDown)
        {
            Destroy(this.gameObject);
            
        }
    }
    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }
    void OnCollisionEnter(Collision coll){
        GameObject otherGO = coll.gameObject;
        if (otherGO.tag == "ProjectileHero"){
            Destroy(otherGO);
            Destroy(gameObject);}
            else
            {
               // print("Enemy hit by non-ProjectileHero: " + otherGO.name);
            }
        
    }
}
