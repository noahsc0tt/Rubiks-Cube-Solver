﻿namespace RubiksCubeSolver.Solver.Forms
{
    partial class WhiteEdges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteEdges));
            finishButton = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            menuButton = new RubiksCubeSolver.Forms.MenuButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // finishButton
            // 
            finishButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            finishButton.Location = new System.Drawing.Point(1155, 720);
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
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            titleLabel.Location = new System.Drawing.Point(453, 45);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(576, 99);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "White Edges";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.white_edges;
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(397, 645);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.MaximumSize = new System.Drawing.Size(689, 178);
            pictureBox1.MinimumSize = new System.Drawing.Size(689, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(689, 178);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(137, 162);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1206, 123);
            label3.TabIndex = 12;
            label3.Text = "The aim of this stage is to have all the white edges facing up. If this is already the case, click the 'Finish' button.\r\n\r\nRead this page carefully before making any moves on your cube.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(137, 307);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1206, 261);
            label2.TabIndex = 14;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuButton
            // 
            menuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            menuButton.BackColor = System.Drawing.Color.LightCyan;
            menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuButton.Location = new System.Drawing.Point(63, 49);
            menuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new System.Drawing.Size(264, 99);
            menuButton.TabIndex = 15;
            menuButton.TabStop = false;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            // 
            // WhiteEdges
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1474, 900);
            Controls.Add(menuButton);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(titleLabel);
            Controls.Add(finishButton);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "WhiteEdges";
            Text = "Top Layer Edges";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RubiksCubeSolver.Forms.MenuButton menuButton;
    }
}