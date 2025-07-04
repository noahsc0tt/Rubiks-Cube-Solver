﻿using System;
using System.Windows.Forms;

namespace Rubiks_Cube_Solver.Forms.Util
{
    internal static class FormNavigator
    {
        public static void Menu(Form currentForm) =>
            Navigate<Menu>(currentForm);

        public static void Navigate<T>(Form currentForm, params object[] args) where T : Form
        {
            Form newForm = (Form)Activator.CreateInstance(typeof(T), args);
            newForm.Show();

            if (currentForm is Menu)
                currentForm.Hide();
            else
                currentForm.Close();
        }
    }
}
