﻿using System;
using System.Windows.Forms;
using Rubiks_Cube_Solver.Forms.Util;

namespace Rubiks_Cube_Solver.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.ApplyDefaultFormSettings();
        }

        private void btnSolver_Click(object sender, EventArgs e) =>
            FormNavigator.Navigate<Solver.Forms.InputPiece>(this, new Solver.Stage());
        
        private void btnTimer_Click(object sender, EventArgs e) =>
            FormNavigator.Navigate<Timer.Forms.BeforeSolve>(this, "N/A");

        private void btnNotation_Click(object sender, EventArgs e) =>
            FormNavigator.Navigate<NotationExplanation>(this);
    }
}