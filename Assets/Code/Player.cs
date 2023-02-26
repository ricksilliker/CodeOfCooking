using System;
using Cinemachine;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Serializable]
    public enum PlayerType
    {
        Winston,
        Ren
    }

    [SerializeField] private CinemachineVirtualCameraBase cam;
    [SerializeField] private Backpack backpack;
    [SerializeField] private Shield shield;
    [SerializeField] private GameObject ren;
    [SerializeField] private GameObject winston;
    
    private StarterAssetsInputs _input;
    private PlayerController _controller;
    private PlayerType _activePlayer = PlayerType.Winston;

    private void Awake()
    {
        _input = GetComponent<StarterAssets.StarterAssetsInputs>();
        _controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        SwitchPlayers(PlayerType.Winston);
    }

    private void Update()
    {
        if (_activePlayer != _input.playerType)
        {
            SwitchPlayers(_input.playerType);
        }
    }

    public void SwitchPlayers(PlayerType newPlayerType)
    {
        _activePlayer = newPlayerType;
        
        CameraRoot root;
        if (_activePlayer == PlayerType.Winston)
        {
            root = winston.GetComponentInChildren<CameraRoot>();
            cam.Follow = root.transform;
            _controller.CinemachineCameraTarget = root.gameObject;
            _controller.activePlayer = winston.transform;
        }
        else
        {
            root = ren.GetComponentInChildren<CameraRoot>();
            cam.Follow = root.transform;
            _controller.CinemachineCameraTarget = root.gameObject;
            _controller.activePlayer = ren.transform;
        }
    }
}
