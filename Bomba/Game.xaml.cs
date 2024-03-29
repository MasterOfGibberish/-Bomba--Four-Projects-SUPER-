﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bomba
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public static Game instanceGame;
        public TextBlock User;
        public Game()
        {
            InitializeComponent();
            instanceGame = this;
            User = VardasPatvirtinimui;
            ResizeMode = ResizeMode.NoResize;
        }

        private bool isDragging;
        private Point offset;


        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            offset = e.GetPosition(this);
            this.CaptureMouse();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            this.ReleaseMouseCapture();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPos = e.GetPosition(this);
                double deltaX = currentPos.X - offset.X;
                double deltaY = currentPos.Y - offset.Y;

                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void sutinku_Click(object sender, RoutedEventArgs e)
        {
            if (Sutikimas.IsChecked == false)
            {
                MessageBox.Show("Sutik, Asile!");
            }
            else
            {
                if (VardasPatvirtinimui.Text == "Neprisijunges")
                {
                    MessageBox.Show("Galima zaisti tik prisijungus");
                    this.Close();
                }
                else
                {
                    Football football = new Football();
                    football.Show();
                    football.Focus();
                    Football.instance2.NameText.Text = VardasPatvirtinimui.Text;
                }
            }
           
        }

        private void Sutikimas_Checked(object sender, RoutedEventArgs e)
        {
           
        }
    }

}
