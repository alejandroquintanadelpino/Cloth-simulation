using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public Vector3 pos;
    public Vector3 vel;
    public Vector3 force;
    private Vector3 gravity;
    private float damp;
    public float mass;
    public bool isFixed;

    public Node(Vector3 p, float m, Vector3 grav, float damping)
    {
        this.pos = p;
        this.vel = Vector3.zero;
        this.force = Vector3.zero;
        this.mass = m;
        this.gravity = grav;
        this.damp = damping;
        this.isFixed = false;
    }

    // Use this for initialization
    /**
    private void Awake()
    {
        pos = transform.position;
        vel = Vector3.zero;
    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = pos;
	}
    /**/
    public void ComputeForces()
    {
        if (!isFixed)
        {
            force += this.mass * this.gravity;
            //force += -damp * vel;
        }
    }

    public void setFixed(bool f)
    {
        this.isFixed = f;
    }
}
