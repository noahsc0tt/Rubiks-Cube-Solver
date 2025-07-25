﻿namespace RubiksCubeSolver.Solver.Forms
{
    partial class PermutingEdges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermutingEdges));
            finishButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            menuButton = new RubiksCubeSolver.Forms.MenuButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // finishButton
            // 
            finishButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            finishButton.Location = new System.Drawing.Point(1225, 737);
            finishButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            finishButton.MinimumSize = new System.Drawing.Size(133, 52);
            finishButton.Name = "finishButton";
            finishButton.Size = new System.Drawing.Size(188, 103);
            finishButton.TabIndex = 3;
            finishButton.TabStop = false;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += FinishButton_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(58, 143);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1356, 78);
            label3.TabIndex = 26;
            label3.Text = "At the end of this stage, the cube will be solved.\r\n\r\nRead this page carefully before making any moves on your cube.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            titleLabel.Location = new System.Drawing.Point(340, 7);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(790, 148);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Permuting Edges";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.pll_bar;
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(604, 590);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(264, 250);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(110, 260);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(1250, 276);
            label4.TabIndex = 29;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuButton
            // 
            menuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            menuButton.BackColor = System.Drawing.Color.LightCyan;
            menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuButton.Location = new System.Drawing.Point(110, 56);
            menuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new System.Drawing.Size(264, 99);
            menuButton.TabIndex = 30;
            menuButton.TabStop = false;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            // 
            // PermutingEdges
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1474, 900);
            Controls.Add(menuButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(titleLabel);
            Controls.Add(finishButton);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "PermutingEdges";
            Text = "Permuting Edges";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label4;
        private RubiksCubeSolver.Forms.MenuButton menuButton;
    }
}