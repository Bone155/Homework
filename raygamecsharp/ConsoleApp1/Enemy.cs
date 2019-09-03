﻿using System;
using System.Collections.Generic;
using System.Text;
using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    struct Vector2E
    {
        public int x;
        public int y;
    }
    class Enemy
    {
        public int speed = 3;
        public Vector2E Position = new Vector2E();
        public Color color = Color.DARKPURPLE;
        public bool isEnabled = true;

        public Texture2D Etexture;
        public float Scale = 1f;

        public void EnemyTexture(string file)
        {
            Etexture = rl.LoadTexture(file);
        }

        public void Draw()
        {
            if (!isEnabled)
                return;
            rl.DrawTextureEx(Etexture, new Vector2(Position.x, Position.y), 0f, Scale, color);
        }
    }
}
