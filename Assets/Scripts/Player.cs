﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public BloodVesselSystem pipeSystem;
    private float deltaToRotation;
    private float systemRotation;
    public float velocity;
    private Transform world, rotater;
    private float worldRotation, avatarRotation;
    public float rotationVelocity;
    private BloodVessel currentPipe;
    // Use this for initialization
    void Start () {
        systemRotation = 0f;
        world = pipeSystem.transform.parent;
        rotater = transform.GetChild(0);
        currentPipe = pipeSystem.SetupFirstPipe();
        SetupCurrentPipe();
    }
	
	// Update is called once per frame
	void Update () {
        float delta = velocity * Time.deltaTime;
        systemRotation += delta * deltaToRotation;
        if (systemRotation >= currentPipe.CurveAngle) {
            delta = (systemRotation - currentPipe.CurveAngle) / deltaToRotation;
            currentPipe = pipeSystem.SetupNextPipe();
            deltaToRotation = 360f / (2f * Mathf.PI * currentPipe.CurveRadius);
            SetupCurrentPipe();
            systemRotation = delta * deltaToRotation;
        }
        pipeSystem.transform.localRotation = Quaternion.Euler(0f, 0f, systemRotation);
        UpdateAvatarRotation();
    }
    private void UpdateAvatarRotation() {
        avatarRotation +=
            rotationVelocity * Time.deltaTime * Input.GetAxis("Horizontal");
        if (avatarRotation < 0f) {
            avatarRotation += 360f;
        } else if (avatarRotation >= 360f) {
            avatarRotation -= 360f;
        }
        rotater.localRotation = Quaternion.Euler(avatarRotation, 0f, 0f);
    }

    private void SetupCurrentPipe() {
        deltaToRotation = 360f / (2f * Mathf.PI * currentPipe.CurveRadius);
        worldRotation += currentPipe.RelativeRotation;
        if (worldRotation < 0f) {
            worldRotation += 360f;
        } else if (worldRotation >= 360f) {
            worldRotation -= 360f;
        }
        world.localRotation = Quaternion.Euler(worldRotation, 0f, 0f);
    }
}
