﻿using UnityEngine;

namespace _Project.Codebase
{
    public static class GameControls
    {
        // Gameplay
        public static readonly KeyBind Up = new KeyBind(KeyCode.W);
        public static readonly KeyBind Down = new KeyBind(KeyCode.S);
        public static readonly KeyBind Left = new KeyBind(KeyCode.A);
        public static readonly KeyBind Right = new KeyBind(KeyCode.D);
        public static readonly KeyBind Fire = new KeyBind(KeyCode.Mouse0);
        public static readonly KeyBind FastCam = new KeyBind(KeyCode.LeftShift);
        public static readonly KeyBind ChangeFireMode = new KeyBind(KeyCode.C);
        public static readonly KeyBind Reload = new KeyBind(KeyCode.R);
        public static readonly KeyBind SetMoveModeToCharacter = new KeyBind(KeyCode.LeftShift);
        
        public static readonly KeyBind MoveMiniMap = new KeyBind(KeyCode.Mouse0);
        public static readonly KeyBind MoveCameraToMiniMapLocation = new KeyBind(KeyCode.Mouse1);
        public static readonly KeyBind MinimapZoomIn = new KeyBind(KeyCode.Comma);
        public static readonly KeyBind MinimapZoomOut = new KeyBind(KeyCode.Period);
        public static readonly KeyBind CenterMap = new KeyBind(KeyCode.C);

        public static readonly KeyBind IncreaseGameSpeed = new KeyBind(KeyCode.RightBracket);
        public static readonly KeyBind DecreaseGameSpeed = new KeyBind(KeyCode.LeftBracket);

        public static float MouseYInput => Input.GetAxisRaw("Mouse Y");
        public static float MouseXInput => Input.GetAxisRaw("Mouse X");
        public static Vector2 MouseInput => new Vector2(MouseXInput, MouseYInput);
        public static Vector2 DirectionalInput => GetDirectionalAxis(Up, Down, Left, Right);

        public static Vector2 GetDirectionalAxis(KeyBind up, KeyBind down, KeyBind left, KeyBind right) => 
            new Vector2(GetAxis(right, left), GetAxis(up, down)).normalized;
        
        public static float GetAxis(KeyBind positive, KeyBind negative)
        {
            float axis = 0;
            if (positive.IsHeld)
                axis += 1f;
            if (negative.IsHeld)
                axis -= 1f;
            return axis;
        }
    }
}