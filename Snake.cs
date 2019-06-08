﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace RanSanMoi
{
    class Snake
    {
        private Rectangle[] snakeRec;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }

        private SolidBrush brush;
        private int x,y,witdh,height;
        //Khoi tao Snake
        public Snake()
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.DarkBlue);
            x = 20; y = 0;witdh = 10;height = 10;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, witdh, height);
                x -= 10; 
            }
        }
        public void drawSnake(Graphics paper)
        {
            foreach (Rectangle rec in snakeRec)
            {
                paper.FillEllipse(brush, rec);
            }
        }
        public void drawSnakeRun()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        public void moveDown()
        {
            drawSnakeRun();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            drawSnakeRun();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            drawSnakeRun();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            drawSnakeRun();
            snakeRec[0].X -= 10;
        }
        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X,snakeRec[snakeRec.Length - 1].Y,witdh,height));
            snakeRec = rec.ToArray();
        }
    }
}
